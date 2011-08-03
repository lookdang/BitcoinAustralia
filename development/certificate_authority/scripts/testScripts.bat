mkdir test
cp -r CleanCA test
cp Openssl.cfg test
cp 00makedirs.bat test
cp 01makeRoot.bat test
cp 02makeIntermediate.bat test
cp 03makeCRL.bat test
cp 04toIntermediaryCA.bat test

cp scripts/demo_request.req test

cd test

start /w ..\scripts\00makedirs.bat
start /w ..\scripts\01makeRoot.bat
start /w ..\scripts\02makeIntermediate.bat
start /w ..\scripts\03makeRootCRL.bat
start /w ..\scripts\04toIntermediaryCA.bat

start /w ..\scripts\10a_MakeAndSignBasicKey.bat
start /w ..\scripts\10b_SignRequest.bat
start /w ..\scripts\15_makeIntermediaryCRL.bat


mkdir cert
cp RootCA/certificates/ca.crt cert
cp RootCA/certificates/intermediary.crt cert/ca1.crt

cd cert
mkdir ca1
cd ..

cp IntermediaryCA/certificates/server1.crt cert/ca1/01.crt
cp IntermediaryCA/certificates/server2.crt cert/ca1/02.crt

mkdir crl
cp RootCA/revoked/ca.crl crl/root_ca.crl
cp IntermediaryCA/revoked/ca.crl crl/ca1.crl


echo Done!