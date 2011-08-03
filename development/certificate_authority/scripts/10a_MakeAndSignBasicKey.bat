cd IntermediaryCA

echo #### Make Basic Server Certificate ####
openssl ecparam -text -name prime256v1 -genkey | openssl pkcs8 -topk8 -v2 aes256 -out private_keys/server1_key.pem
openssl req -config ../Openssl.cfg -new -key private_keys/server1_key.pem -out requests/server1.req
openssl ca -config ../Openssl.cfg -in requests/server1.req
openssl x509 -in certificates/01.pem -out certificates/server1.crt

cd ..
