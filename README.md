# Phone Number Methods Library

### About
This library provide all required functions for Cell phonenumbers to check if phonenumbers is correct or not.And returns Correct phonenumber with country code for save it in database.

### Features
- Check patern of input PhoneNumber. (e.x) +98 937-***-**** is correct.     
- Check country code of phonenumber. All Countries code as ISO (2-Digit) 
- Convert Persian And Arabic Digits to English Digits. 
- Discover name of country from PhoneNumber.

Some new Features will add to this package SOON!

### Install
After add Package to your project, Call this method to get correct phone number for you database:

```
var result = PhoneNumberMethod.GetCorrectPhoneNumber("YOUR PHONENUMER");
if (result.IsSuccess)
{
  // You can Check this Outputs
              
  // result.Message 
  // result.CorrectPhoneNumber
  // result.Country.Name
  // result.Country.ISO
  // result.Country.Code
}
else
{
   // Check result.Message 
}
```
