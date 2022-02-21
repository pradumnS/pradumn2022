using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using NLog;
using System.Collections;

using System.IO;

using System.Security.Cryptography.X509Certificates;
//AuxiAddonNBFCHostEntityOTPRequestInterface
using AuxiAddonNBFCHostEntityOTPRequestInterface; 
namespace GenericNBFCInerfaceService
{
    public partial class GenericNBFCService : ServiceBase
    {
       
        private System.Threading.Thread _thread;
        RegistrationServices regServices = new RegistrationServices();
        int icookieGenericNBFC = 0;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public GenericNBFCService()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            try
            {
                string strHCPublicKeyPath = "";              
                strHCPublicKeyPath = System.Configuration.ConfigurationManager.AppSettings["HomeCreditKeyFile"];
                Dictionary<string, string> strHCDictionary = LoadConfig(strHCPublicKeyPath);              
                foreach (KeyValuePair<string, string> author in strHCDictionary)
                {
                    if ("HCPrivateKeyPath" == author.Key)
                    {
                        Constant.HCPrivateKey = author.Value;
                        logger.Info(" Constant.HCPrivateKey : " +  Constant.HCPrivateKey + "\n");
                    }
                    if ("HCPublicKeyPath" == author.Key)
                    {
                        Constant.HCPublicKey = author.Value;
                        logger.Info(" Constant.HCPrivateKey : " +  Constant.HCPrivateKey + "\n");
                    }
                }

                string strAUPublicKeyPath = "";
                strAUPublicKeyPath = System.Configuration.ConfigurationManager.AppSettings["AUKeyFile"];
                Dictionary<string, string> strAUDictionary = LoadConfig(strAUPublicKeyPath);
                foreach (KeyValuePair<string, string> author in strAUDictionary)
                {
                    if ("AUPrivateKeyPath" == author.Key)
                    {
                        Constant.AUPrivateKey = author.Value;
                        //logger.Info(" Constant.AUPrivateKey : " + Constant.AUPrivateKey + "\n");

                    }
                    if ("AUPublicKeyPath" == author.Key)
                    {
                        Constant.AUPublicKey = author.Value;
                        //logger.Info(" Constant.AUPrivateKey : " + Constant.AUPrivateKey + "\n");

                    }
                }
                // Create the thread object that will do the service's work.
                _thread = new System.Threading.Thread(DoWork);

                // Start the thread.
                _thread.Start();
                //logger.Info(" Successfully Start... ");
                // Log an event to indicate successful start.
                EventLog.WriteEntry("Successful start.", EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                // Log the exception.
                EventLog.WriteEntry(ex.Message, EventLogEntryType.Error);
            }
        }

        private void DoWork()
        {
            icookieGenericNBFC = regServices.RegisterTypeForComClients(
               typeof(AuxiAddonNBFCHostEntityOTPRequestInterface.CAuxiAddonNBFCHostEntityOTPRequestHandler),
               RegistrationClassContext.LocalServer | RegistrationClassContext.RemoteServer,
               RegistrationConnectionType.MultipleUse);
            // Console.WriteLine("Ready"); Console.ReadKey();

        }
        protected override void OnStop()
        {
            regServices.UnregisterTypeForComClients(icookieGenericNBFC);
        }
        public Dictionary<string, string> LoadConfig(string settingfile)
        {
            var dic = new Dictionary<string, string>();

            if (File.Exists(settingfile))
            {
                var settingdata = File.ReadAllLines(settingfile);
                for (var i = 0; i < settingdata.Length; i++)
                {
                    var setting = settingdata[i];
                    var sidx = setting.IndexOf("=");
                    if (sidx >= 0)
                    {
                        var skey = setting.Substring(0, sidx);
                        var svalue = setting.Substring(sidx + 1);
                        if (!dic.ContainsKey(skey))
                        {
                            dic.Add(skey, svalue);
                        }
                    }
                }
            }

            return dic;
        }
    }  
}

/*
{
                string strHCPublicKeyPath = "";
                string strHCPLPrivateKeyPath = "";

                strHCPublicKeyPath = System.Configuration.ConfigurationManager.AppSettings["HCPublicKeyPath"];
                strHCPLPrivateKeyPath = System.Configuration.ConfigurationManager.AppSettings["HCPLPrivateKeyPath"];
                string strIsPrivateKeyInPEMFormat = System.Configuration.ConfigurationManager.AppSettings["SBIIsPEMPrivateKey"];
                if (strIsPrivateKeyInPEMFormat == "1")
                {
                    Constant.bIsHCPrivateKeyInPEMFormat = true;
                }
                else
                {
                    Constant.bIsHCPrivateKeyInPEMFormat = false;
                }
                //GetSbiDebitCertificateParameters(Constant.ObjIniConstData);
                GetSbiDebitCertificateParameters(strHCPublicKeyPath, strHCPLPrivateKeyPath);
                // Uncomment this line to debug...
                //System.Diagnostics.Debugger.Break();

                // Create the thread object that will do the service's work.
                _thread = new System.Threading.Thread(DoWork);

                // Start the thread.
                _thread.Start();

                // Log an event to indicate successful start.
                EventLog.WriteEntry("Successful start.", EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                // Log the exception.
                EventLog.WriteEntry(ex.Message, EventLogEntryType.Error);
            }
        }

        private void DoWork()
        {
            icookieGenericNBFC = regServices.RegisterTypeForComClients(
               typeof(AuxiAddonNBFCHostEntityOTPRequestInterface.CAuxiAddonNBFCHostEntityOTPRequestHandler),
               RegistrationClassContext.LocalServer | RegistrationClassContext.RemoteServer,
               RegistrationConnectionType.MultipleUse);
            // Console.WriteLine("Ready"); Console.ReadKey();

        }
        private void GetSbiDebitCertificateParameters(string SBIPublicKeyPath, string PLPrivateKeyPath)
        {
            if ((string.IsNullOrEmpty(SBIPublicKeyPath)) || (string.IsNullOrEmpty(PLPrivateKeyPath)))
            {
                return;
            }
           // Constant.SBIx509RSAPublicKey = GetX509CertificateParameters(SBIPublicKeyPath);
            if (false == Constant.bIsHCPrivateKeyInPEMFormat)
            {
                Constant.HCRSAPrivateKey = readRSAPrivateKey(PLPrivateKeyPath);
            }
            else
            {
                Constant.HCRSAPrivateKey = readPrivateKey(PLPrivateKeyPath);
            }
        }

        private AsymmetricKeyParameter readRSAPrivateKey(string privateKeyFileName)
        {
            try
            {
                AsymmetricCipherKeyPair keyPair;

                using (var reader = File.OpenText(privateKeyFileName))
                    keyPair = (AsymmetricCipherKeyPair)new PemReader(reader).ReadObject();

                return keyPair.Private;
            }
            catch (Exception ex)
            {
                string strLog = (string)"EXCEPTION: " + ex.Message.ToString() + ex.GetType().Name.ToString();
                //logger.Info("readRSAPrivateKey() FAILED , strLog = " + strLog);
                return null;
            }
        }
        //private key is in .pem format starting with BEGIN PRIVATE KEY, contains only private key part (open ssl command:openssl req -x509 -days 1095 -nodes -newkey rsa:2048 -keyout key5.pem -out cert5.pem -sha256)
        static AsymmetricKeyParameter readPrivateKey(string privateKeyFileName)
        {
            try
            {
                AsymmetricKeyParameter key;
                using (var reader = File.OpenText(privateKeyFileName))
                {
                    key = (AsymmetricKeyParameter)new PemReader(reader).ReadObject();
                }
                return key;
            }
            catch (Exception ex)
            {
                string strLog = (string)"EXCEPTION: " + ex.Message.ToString() + ex.GetType().Name.ToString();
                //logger.Info("readPrivateKey() FAILED , strLog = " + strLog);
                return null;
            }
        }

        protected override void OnStop()
        {
            regServices.UnregisterTypeForComClients(icookieGenericNBFC);
        }
    }
}
*/
