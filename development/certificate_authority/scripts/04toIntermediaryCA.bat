
echo #### Move to IntermediaryCA Directory + copy over certificate and private key ####
cp RootCA/private_keys/intermediary_key.pem IntermediaryCA/private_keys/ca_key.pem
cp RootCA/certificates/intermediary.crt IntermediaryCA/certificates/ca.crt
