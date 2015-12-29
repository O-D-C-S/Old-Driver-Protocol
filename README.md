# OldDriverProtocol
老司机协议是用于即时聊天中老司机开车的协议标准

##How to use ODP(Old Driver Protocol)?

###As Old Driver
use Old Driver Protocol Standard to encode your resource link, and send the encoded plain text to others
###As Driving Beginner
When you recieve a mystery plain text from the Old Drivers, use the Old Driver Protocol to decode the encoded plain text, and you get the resource.

##History
2015.12.30: v0.1 protocol standard release
2015.12.27: First presented in ACG Hackers QQ Group

#ODP Standard v0.1
###0. Requirement
The key words "MUST", "MUST NOT", "REQUIRED", "SHALL", "SHALL NOT", "SHOULD", "SHOULD NOT", "RECOMMENDED", "MAY", and "OPTIONAL" in this document are to be interpreted as described in RFC 2119
###1. Terminology
`ODP Header`
A Old Driver Protocol Message Structure's Begin Tag.

*Requirement Level: MUST*
*Format: ODP/[ODPversion]*
*e.g: ODP/0.1*

`Resource Type`
The statement of the resource type which this ODP Message contains.

*Requirement Level: OPTIONAL* 
*Format: Type/[ResourceType]*
*Option: NetDisk, PlainText, Image, URI(RFC 3305), MIME(RFC 2045, RFC 2046, RFC 2047, RFC 2048, RFC 2049, etc.)*
*e.g: Type/NetDisk*

`ODP Content`
The Content of Resource. **A empty line before it is Required**.

*Requirement Level: MUST*
*Format: [MsgContent]*
*e.g: http://pan.baidu.com/xxxx*

###2. Message Content Structure
Example:
ODP/0.1**\r\n**
Type/NetDisk**\r\n**
**\r\n**
http://pan.baidu.com/xxxx
