cd RootCA

echo #### Make Root Certifcation Certificate ####
openssl ecparam -text -name prime256v1 -genkey | openssl pkcs8 -topk8 -v2 aes256 -out private_keys/ca_key.pem
openssl req -config ../Openssl.cfg -new -reqexts req_root_ca -key private_keys/ca_key.pem -out requests/ca.req
openssl ca -config ../Openssl.cfg -policy root_policy -extensions sign_root_cert -days 3650 -selfsign -in requests/ca.req
openssl x509 -in certificates/01.pem -out certificates/ca.crt

echo #### Make Intermediate Certifcation Certificate ####
openssl ecparam -text -name prime256v1 -genkey | openssl pkcs8 -topk8 -v2 aes256 -out private_keys/intermediary_key.pem
openssl req -config ../Openssl.cfg -new -reqexts req_intermediary_ca -key private_keys/intermediary_key.pem -out requests/intermediary.req
openssl ca -config ../Openssl.cfg -policy root_policy -extensions sign_intermediary_cert -in requests/intermediary.req
openssl x509 -in certificates/02.pem -out certificates/intermediary.crt

echo #### Make Revercation Certificate ####
openssl ca -config ../Openssl.cfg -gencrl -out revoked/ca.crl

echo #### Move to IntermediaryCA Directory + copy over certificate and private key ####
cd ..
cp RootCA/private_keys/intermediary_key.pem IntermediaryCA/private_keys/ca_key.pem
cp RootCA/certificates/intermediary.crt IntermediaryCA/certificates/ca.crt
cd IntermediaryCA

echo #### Make Basic Server Certificate ####
openssl ecparam -text -name prime256v1 -genkey | openssl pkcs8 -topk8 -v2 aes256 -out private_keys/server1_key.pem
openssl req -config ../Openssl.cfg -new -key private_keys/server1_key.pem -out requests/server1.req
openssl ca -config ../Openssl.cfg -in requests/server1.req
openssl x509 -in certificates/01.pem -out certificates/server1.crt

echo #### Sign a 3rd Party Certificate Request ####
cp ../server2.req requests/server2.req
openssl ca -config ../Openssl.cfg -in requests/server2.req
openssl x509 -in certificates/02.pem -out certificates/server2.crt

echo #### Make Revercation Certificate ####
openssl ca -config ../Openssl.cfg -gencrl -out revoked/ca.crl