cd IntermediaryCA

echo #### Make Revercation Certificate ####
openssl ca -config ../Openssl.cfg -gencrl -out revoked/ca.crl

cd ..

