# 老司机协议标准 v0.3

## 0x00 ODP 简介
老司机协议(Old Driver Protocol ，以下简称 ODP)是用于社交网络中老司机发车的协议标准。

欢迎对发车标准化有兴趣的你提交 issue，或者直接提交 PullRequest。

## 0x01 ODP 协议分类概述
本协议分为`Fast-ODP`和`Classic-ODP`两种版本。

`Fast-ODP`基于 AES 本地加解密，适用于个人快速发车；

`Classic-ODP`则基于云端的非对称加密数据交换，需要架设加解密数据交换节点，适用于大量发车，可统计资源热度，一键销毁所有资源。

## 0x02 ODP 消息体结构概述
* Fast-ODP
  * `odp://AES(local@Content)/`
* Classic-ODP
  * `odp://AES(remote@Server:port@ContentEncryptByRSAPublicKey)/`

## 0x03 Fast-ODP
消息体结构: `odp://AES(local@base64(Content))/`

Url Scheme 开头: odp://

ODP 类型标识: local  *(即本地模式, Fast-ODP)*

发车内容: Content (任意内容base64编码之后的字符串)

## 0x04 Classic-ODP (尚未完成)
消息体结构: `odp://AES(remote@Server:port@ContentEncryptByRSAPublicKey)/`

*Classic-ODP的消息体结构与Fast-ODP类似，这里不再赘述*

Classic-ODP 的加密流程：

ODP-Server 角色(即 0x01 部分提到的加解密数据交换节点):

第一次运行时生成 RSA 密钥对，并持久化储存

公开公钥，`ContentEncryptByRSAPublicKey` 部分由老司机使用公钥加密

Classic-ODP 的解密流程：

乘客 角色通过最外层的 AES 解密后得到 ODP-Server 的网络地址和运行端口，以及通过 RSA 公钥加密的内容

乘客 角色生成一个临时的 AES 密钥(仅有效一次, 256位加密标准)，将该密钥和获得的加密内容提交给 ODP-Server

ODP-Server 使用私钥解密内容，并使用乘客生成的 AES 密钥再次加密内容，返回给乘客

乘客使用 AES 解密内容，获得明文信息

## 0x05 ODP 发车流程范例
**按照一般的需求，一次基于 ODP 标准的发车可能最少需要以下几个部分：**
`资源描述` `ODP 标准消息体` `AES Key`

## Many TODOs