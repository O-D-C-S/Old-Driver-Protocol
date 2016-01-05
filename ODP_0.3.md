# 老司机协议标准 v0.3

## 0x00 ODP 简介
老司机协议(Old Driver Protocol ，以下简称 ODP)是用于社交网络中老司机发车的协议标准。

**欢迎对发车标准化有兴趣的你提交 issue，或者直接提交 PullRequest。**

## 0x01 ODP 协议分类概述
本协议分为`Fast-ODP`和`Classic-ODP`两种版本。

 * `Fast-ODP`基于 AES 本地加解密，适用于个人快速发车；

 * `Classic-ODP`则基于云端的非对称加密数据交换，需要架设加解密数据交换节点，适用于大量发车，可统计资源热度，一键销毁所有资源。

## 0x02 ODP 消息体结构概述
* Fast-ODP
  * `odp://base64(AES(local@base64(Content)))/`
* Classic-ODP
  * `odp://base64(AES(remote@Server:port@RSAEncryptContent))/`

## 0x03 Fast-ODP
消息体结构: `odp://base64(AES(local@base64(Content)))/`

 * Url Scheme 开头: `odp://`

 * ODP 类型标识: `local`  *(即本地模式, Fast-ODP)*

 * 发车内容: `Content`

## 0x04 Classic-ODP
消息体结构: `odp://base64(AES(remote@Server:port@RSAEncryptContent))/`

 * Url Scheme 开头: `odp://`

 * ODP 类型标识: `remote`  *(即远端模式, Classic-ODP)*

 * 发车内容: `Content`
  * **加密流程：**
  * ODP-Server (即 0x01 部分提到的加解密数据交换节点) 第一次运行时生成 RSA 密钥对，持久化储存，**公开公钥**。
  * 对 Content 明文进行 base64 编码，再使用公钥对 base64 编码之后的内容进行加密。
  * **解密流程：**
  * 通过最外层的 AES 解密后得到 ODP-Server 的网络地址和运行端口，以及 Content 密文。
  * 乘客生成一个临时的 AES 密钥(256位，仅使用一次)，将该 AES 密钥和 Content 密文提交给 ODP-Server。
  * ODP-Server 使用 RSA 私钥解密，并使用乘客生成的 AES 密钥再次加密内容，返回给乘客
  * 乘客使用 AES 密钥解密，再进行 base64 解码，获得 Content 明文。
  * **关于 ODP-Server：**
  * 通过乘客对 ODP-Server 的请求，可以统计出资源热度。
  * 重新生成并销毁之前的 RSA 密钥对，可将这之前通过该 ODP-Server 发布的资源进行销毁。
  * 请勿通过 ODP-Server 收集用户的隐私信息，降低风险。

## 0x05 ODP 发车流程范例
**按照一般的需求，一次基于 ODP 标准的发车可能最少需要以下几个部分：**

`资源描述` `ODP 标准消息体` `AES Key`

一个简单的发车范例（内容为虚构）：

> 本次发车基于 ODP 发车协议

> 代号：HITMA-262

> 代码：odp://***************************************/

> 密码: ********************************

## Many TODOs
