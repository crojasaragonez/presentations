source ./express_js/.env
sudo cp ./systemd_files/express_app.service /usr/lib/systemd/system/express_app.service
sudo systemctl daemon-reload
sudo systemctl start express_app.service
sudo systemctl enable express_app.service
gio open http://localhost:$PORT # open app using default browser
#sudo journalctl -u express_app.service
