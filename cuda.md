mobaxterm
10.172.124.51
username: megao
password: Microsoft123#
sudo su        Microsoft123#

ssh cs@10.172.125.9

下载 anaconda 
<!-- conda install -c anaconda cudatoolkit 
conda install -c anaconda cudnn  -->
conda install pytorch torchvision cudatoolkit=10.0 -c pytorch
conda install -c derickl torchtext 

tar -zxvf file "/home/megao/Anaconda3-2019.03-Linux-x86_64.sh"
apt install default-jre
"/home/megao/pycharm-community-anaconda-2019.1.1/bin/pycharm.sh"
unzip dir 
 chmod -R 777 "/home/megao/"
 
nvidia-smi

watch -n 1 nvidia-smi

(base) megao@qiying:~$ kill 05919
kill5919: command not found
(base) megao@qiying:~$ watch -n 1 nvidia-smi
Every 1.0s: nvidia-smi                                                                                                                                                         qiying: Sun Apr  7 19:58:39 2019

Sun Apr  7 19:58:39 2019
+-----------------------------------------------------------------------------+
| NVIDIA-SMI 418.56       Driver Version: 418.56       CUDA Version: 10.1     |
|-------------------------------+----------------------+----------------------+
| GPU  Name        Persistence-M| Bus-Id        Disp.A | Volatile Uncorr. ECC |
| Fan  Temp  Perf  Pwr:Usage/Cap|         Memory-Usage | GPU-Util  Compute M. |
|===============================+======================+======================|
|   0  GeForce GTX 1080    Off  | 00000000:65:00.0  On |                  N/A |
| 55%   82C    P2   162W / 180W |   4804MiB /  8110MiB |     99%      Default |
+-------------------------------+----------------------+----------------------+

+-----------------------------------------------------------------------------+
| Processes:                                                       GPU Memory |
|  GPU       PID   Type   Process name                             Usage      |
|=============================================================================|
|    0      1201      G   /usr/lib/xorg/Xorg                            18MiB |
|    0      1235      G   /usr/bin/gnome-shell                          48MiB |
|    0      1399      C   python                                      4565MiB |
|    0      1413      G   /usr/lib/xorg/Xorg                            86MiB |
|    0      1543      G   /usr/bin/gnome-shell                          81MiB |
+-----------------------------------------------------------------------------+

winscp管理文件
jupyter notebook

代码中使用

demo.pyhton 

device = torch.device('cuda' if torch.cuda.is_available() else 'cpu')

a =Variable(list[][])
if torch.cuda.is_available(a)
    a=a.cuda()

/home/megao/anaconda3/bin/python
