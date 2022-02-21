# Assessment-Test-Submission
Assessment Test Submission Jaka Priatna

Ikuti langkah-langkah di bawah ini untuk menjalankan aplikasi:

Step 1 : Publish application:

dotnet publish -c release -r ubuntu.16.04-x64 --self-contained

Step 2 : Copy publish folder ke Ubuntu
Step 3 : Buka terminal Ubuntu (CLI) dan buka direktori aplikasi
Step 4 : Jalankan script berikut untuk mengeksekusi aplikasi

chmod 777 ./Mytools

Step 5 : Eksesuki aplikasi

./Mytools


Contoh

./Mytools ~/var/nginx/message.log

Result: merubah file .log menjadi .txt

./Mytools ~/var/nginx/message.log -t json

Result: merubah file .log menjadi .json

./Mytools ~/var/nginx/message.log -o ./Mytools ~/Document/messages.txt

Result: merubah file .log menjadi .txt dan menyimpan di direktori baru

./Mytools ~/var/nginx/message.log -t json -o ./Mytools ~/Document/messages.json

Result: merubah file .log menjadi .json dan menyimpan di direktori baru
