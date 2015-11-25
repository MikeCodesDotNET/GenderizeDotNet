# GenderizeDotNet
A .NET library for querying Genderize

This is a super simple library for interacting with the Genderize API. 

##How to use it
```c#
var client = new GenderizeDotNet.Client();
var result = await client.GenderizeSingleName("mike");
```
