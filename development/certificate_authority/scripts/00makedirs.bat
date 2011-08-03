mkdir RootCA
cd RootCA

mkdir certificates
mkdir database
mkdir private_keys
mkdir requests
mkdir revoked

touch database/index.txt

cp ../CleanCA/database/serial.txt database
cp ../CleanCA/revoked/crlnumber.txt revoked

cd ..

mkdir IntermediaryCA
cd IntermediaryCA

mkdir certificates
mkdir database
mkdir private_keys
mkdir requests
mkdir revoked

touch database/index.txt

cp ../CleanCA/database/serial.txt database
cp ../CleanCA/revoked/crlnumber.txt revoked

cd ..