# Phone Number Methods Library

### About Library
This library provide all required functions for Cell phonenumbers to check if phonenumbers is correct or not.And returns Correct phonenumber with country code for save phonenumber in database.

### Features
- Check patern of input PhoneNumber. (e.x) +98 937-***-**** is correct.     
- Ch

### Install
After add Package to your project

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
