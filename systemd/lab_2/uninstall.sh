sudo systemctl stop time_scheduler.timer
sudo systemctl disable time_scheduler.timer
sudo systemctl daemon-reload
sudo rm -f /usr/lib/systemd/system/time_scheduler.timer
sudo rm -f /usr/lib/systemd/system/time_scheduler.service
