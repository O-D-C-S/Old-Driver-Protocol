#ODP Standard v0.2
###0. Requirement
The key words "MUST", "MUST NOT", "REQUIRED", "SHALL", "SHALL NOT", "SHOULD", "SHOULD NOT", "RECOMMENDED", "MAY", and "OPTIONAL" in this document are to be interpreted as described in RFC 2119

The following signs are used to adjunctively describe the structure inside of a format declaration
*  [argument] : represents that the argument is OPTIONAL
*  (argument) : represents that the argument is a tag or another meaningful expression
*  {1-10} : represents that the argument MUST be in the declared range. `i.e. from 1 to 10`
*  arg1|arg2 : represents that either arg1 or arg2 is acceptable `i.e. [a|b] represents that either a or b, or empty is valid`


###1. Terminology
* **ODP Header**

  * *Description:* An Old Driver Protocol Message Structure's Begin Tag.

  * *Requirement Level:* MUST

  * *Format:* ODP/(ODPversion) \[(Operation)\]

  * *Operations:* DRIVING, REQUEST, PREVIEW

  * *e.g.* ODP/0.2 DRIVING

* **Resource Type**

  * *Description:* The statement of the resource type which this ODP Message contains.

  * *Requirement Level:* OPTIONAL

  * *Format:* Type/(ResourceType)

  * *ResourceTypes:* Image, URI(RFC 3305), MIME(RFC 2045, RFC 2046, RFC 2047, RFC 2048, RFC 2049, etc.)

  * *e.g.* Type/NetDisk

* **ODP Content**

  * *Description:* The Content of Resource. **An empty line before this part is Required**.

  * *Requirement Level:* MUST

  * *Format:* (ResourceContent) | ShousaiKibou

  * *ResourceContents:* Same as Resource Type | Passengers' request

  * *e.g.* http://pan.baidu.com/xxxx *(The content can be a single image without type declaraion when PREVIEW defined in header)*

* **ODP Ending**

  * *Description:* Marks that ODP Message ends.

  * *Requirement Level:* RECOMMENDED

  * *Format:* ODP/END


###2. Message Content Structure

`ODP Header`*\r\n*

`Resource Type`*\r\n*

*\r\n*

`ODP Content`*\r\n*

`ODP Ending`
