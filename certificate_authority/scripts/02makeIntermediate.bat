cd RootCA

echo #### Make Intermediate Certifcation Certificate ####
openssl ecparam -text -name prime256v1 -genkey | openssl pkcs8 -topk8 -v2 aes256 -out private_keys/intermediary_key.pem
openssl req -config ../Openssl.cfg -new -reqexts req_ca_cert -key private_keys/intermediary_key.pem -out requests/intermediary.req
openssl ca -config ../Openssl.cfg -policy root_policy -extensions sign_intermediary_cert -in requests/intermediary.req
openssl x509 -in certificates/02.pem -out certificates/intermediary.crt

cd ..
