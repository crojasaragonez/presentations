sudo systemctl stop express_app.service
sudo systemctl disable express_app.service
sudo rm -f /usr/lib/systemd/system/express_app.service
sudo systemctl daemon-reload
