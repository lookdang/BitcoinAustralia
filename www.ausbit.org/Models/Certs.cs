using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www.ausbit.org.Models
{
    /// <summary>
    /// Basic Cert Database
    /// </summary>
    public class Certs
    {
        public Certificate root;
        public List<Certificate> certs { get; set; }


        public Certs()
        {
            certs = new List<Certificate>();

            
            certs.Add(rootCert());
            certs.Add(intermediaryCert());
            
        }

        private Certificate rootCert()
        {
            var cert = new Certificate();
            cert = new Certificate();
            cert.Name = "Bitcoin Australia Certification Authority";
            cert.Level = "Root";
            cert.Data = @"-----BEGIN CERTIFICATE-----
MIIC9DCCApqgAwIBAgIBATAKBggqhkjOPQQDAjB9MRowGAYDVQQKDBFCaXRjb2lu
IEF1c3RyYWxpYTErMCkGA1UECwwiU2VjdXJlIERpZ2l0YWwgQ2VydGlmaWNhdGUg
U2lnbmluZzEyMDAGA1UEAwwpQml0Y29pbiBBdXN0cmFsaWEgQ2VydGlmaWNhdGlv
biBBdXRob3JpdHkwHhcNMTEwNzMxMTcyNTE5WhcNMjEwNzI4MTcyNTE5WjB9MRow
GAYDVQQKDBFCaXRjb2luIEF1c3RyYWxpYTErMCkGA1UECwwiU2VjdXJlIERpZ2l0
YWwgQ2VydGlmaWNhdGUgU2lnbmluZzEyMDAGA1UEAwwpQml0Y29pbiBBdXN0cmFs
aWEgQ2VydGlmaWNhdGlvbiBBdXRob3JpdHkwWTATBgcqhkjOPQIBBggqhkjOPQMB
BwNCAAQwgtVlwebKzDEL+zTmD72kmvu5BGvjwJPovT1G9z87aEtTC5N79/8JFwxX
C977Mngz1QobFjbIU9lsL3ojM978o4IBCTCCAQUwDAYDVR0TBAUwAwEB/zALBgNV
HQ8EBAMCAa4wHQYDVR0OBBYEFL6YNhK+TGSa0VjifwtGY3td3aHQMDsGA1UdJQQ0
MDIGCCsGAQUFBwMBBggrBgEFBQcDAgYIKwYBBQUHAwQGCCsGAQUFBwMDBggrBgEF
BQcDCDCBiwYDVR0fBIGDMIGAMCegJaAjhiFodHRwOi8vY3JsLmF1c2JpdC5vcmcv
cm9vdF9jYS5jcmwwKKAmoCSGImh0dHA6Ly9jZXJ0LmF1c2JpdC5vcmcvcm9vdF9j
YS5jcmwwK6ApoCeGJWh0dHA6Ly9jZXJ0LmJ0Y2F1cy5jb20vYmFfcm9vdF9jYS5j
cmwwCgYIKoZIzj0EAwIDSAAwRQIhAME7oOxnijk6YvfrfQOKqNGLTM+ykxqR5dL9
pK7spWBHAiAMOtvVGJJu2appsl2o80U6//Xeu3/DzlfHgu/TqhvWnA==
-----END CERTIFICATE-----";
            cert.Thingerprint = "cffe886aef0839d8bd4a7cdf72d636a35d01f203";
            return cert;
        }

        private Certificate intermediaryCert()
        {
            var cert = new Certificate();
            cert = new Certificate();
            cert.Name = "Bitcoin Australia Intermediary CA 1";
            cert.Level = "Intermediary";
            cert.Data = @"-----BEGIN CERTIFICATE-----
MIIC8DCCApegAwIBAgIBAjAKBggqhkjOPQQDAjB9MRowGAYDVQQKDBFCaXRjb2lu
IEF1c3RyYWxpYTErMCkGA1UECwwiU2VjdXJlIERpZ2l0YWwgQ2VydGlmaWNhdGUg
U2lnbmluZzEyMDAGA1UEAwwpQml0Y29pbiBBdXN0cmFsaWEgQ2VydGlmaWNhdGlv
biBBdXRob3JpdHkwHhcNMTEwNzMxMTczMTM3WhcNMTIwNzMwMTczMTM3WjB3MRow
GAYDVQQKDBFCaXRjb2luIEF1c3RyYWxpYTErMCkGA1UECwwiU2VjdXJlIERpZ2l0
YWwgQ2VydGlmaWNhdGUgU2lnbmluZzEsMCoGA1UEAwwjQml0Y29pbiBBdXN0cmFs
aWEgSW50ZXJtZWRpYXJ5IENBIDEwWTATBgcqhkjOPQIBBggqhkjOPQMBBwNCAARx
Rh71UjcdQsC24PDOME3NbQjm//BX/v6SkgjbP8d0sPcDhySuN8D4ARdAXATivrIN
XAuGGhzIj8MiFFdscl5do4IBDDCCAQgwDAYDVR0TBAUwAwEB/zALBgNVHQ8EBAMC
AQYwHQYDVR0OBBYEFCwhyuLeM/cRMmKgAHUyNuWhc/wPMIGLBgNVHR8EgYMwgYAw
J6AloCOGIWh0dHA6Ly9jcmwuYXVzYml0Lm9yZy9yb290X2NhLmNybDAooCagJIYi
aHR0cDovL2NlcnQuYXVzYml0Lm9yZy9yb290X2NhLmNybDAroCmgJ4YlaHR0cDov
L2NlcnQuYnRjYXVzLmNvbS9iYV9yb290X2NhLmNybDA+BggrBgEFBQcBAQQyMDAw
LgYIKwYBBQUHMAKGImh0dHA6Ly9jZXJ0LmF1c2JpdC5vcmcvcm9vdF9jYS5jcnQw
CgYIKoZIzj0EAwIDRwAwRAIgAMErq/ZR6FrLf7h3tOETrQzPHV2xoJc3luRsy74U
GN4CIHjT+7cWjzw1/XiSeGbuLPy1O1xoC0eg/m7v2sIbklxE
-----END CERTIFICATE-----";
            cert.Thingerprint = "‎547303cdbc9ac4b437932b472d052d5b62ef0b8c";
            return cert;
        }
    }

    public struct Certificate
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Data { get; set; }
        public string Thingerprint { get; set; }
    }
}
