cd RootCA

echo #### Make Root Certifcation Certificate ####
openssl ecparam -text -name prime256v1 -genkey | openssl pkcs8 -topk8 -v2 aes256 -out private_keys/ca_key.pem
openssl req -config ../Openssl.cfg -new -reqexts req_ca_cert -key private_keys/ca_key.pem -out requests/ca.req
openssl ca -config ../Openssl.cfg -policy root_policy -extensions sign_root_cert -days 3650 -selfsign -in requests/ca.req
openssl x509 -in certificates/01.pem -out certificates/ca.crt

cd ..
