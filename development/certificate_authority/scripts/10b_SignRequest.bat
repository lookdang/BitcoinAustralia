cd IntermediaryCA

echo #### Sign a 3rd Party Certificate Request ####
cp ../demo_request.req requests/server2.req
openssl ca -config ../Openssl.cfg -in requests/server2.req
openssl x509 -in certificates/02.pem -out certificates/server2.crt

cd ..
