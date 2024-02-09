sudo cp ./systemd_files/time_scheduler.service /usr/lib/systemd/system/time_scheduler.service
sudo cp ./systemd_files/time_scheduler.timer /usr/lib/systemd/system/time_scheduler.timer
sudo systemctl daemon-reload
sudo systemctl start time_scheduler.timer
sudo systemctl enable time_scheduler.timer
sudo systemctl list-timers | grep time_scheduler.timer
#sudo journalctl -u time_scheduler.timer
