# Phone Number Methods Library

### About
This library provides all required functions for Cell phone numbers to check if phone numbers are correct or not. And returns the Correct phone number with the country code to save it in the database.

### Features
- Check patterns of the input phone number. (e.x) +98 937-***-**** is correct.     
- Check country code of phone number. All Countries code as ISO (2-Digit) 
- Convert Persian And Arabic Digits to English Digits. 
- Discover name of country from phone number.

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
