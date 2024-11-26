# Deposit Calculator

## _Task:_
Develop a Deposit Calculator application using either WPF or Windows Forms. The application should allow users to input the deposit amount, term (in months), choose the interest payment method (capitalization or monthly payout), and select the currency. The application should then display the expected income based on the provided information.

## _Assumptions:_
- Payment methods, currency and units could be **hardcoded**
- **Annual Interest Rate** should depend on selected **currency**
- **Compounding** frequency for the case of **Capitalization** interest payment method is **once per month**
- Calculation formula for for the case of **Capitalization** interest payment method could be taken from [Compound interest (Wikipedia)](https://en.wikipedia.org/wiki/Compound_interest#Periodic_compounding)

## _Example data setup:_
All the example data is hardcoded in the **DataProviderService** class. Two corresponded lists are used: *_currencies* and *_paymentMethods*.

## _Dependencies:_
- .NET 8.0
- [MahApps.Metro](https://www.nuget.org/packages/mahapps.metro/)
- [Prism.Unity](https://www.nuget.org/packages/Prism.Unity)
