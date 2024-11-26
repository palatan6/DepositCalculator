# Deposit Calculator

![Screenshot](https://d3dehtdmp2rwcw.cloudfront.net/ms_610957/2U2hCZFy1q2W3OhDbCA8eATlCA6Yz5/Screenshot%2B2024-11-27%2B003736.png?Expires=1732662000&Signature=USWAJ2EG-rJXPLXu8nqvRe6ZiQ2sc-niaqOeRMnvLslQ3t6rRs4M3GgnFbpQTI7arxSEjJ77-aO2I2toWlaUL0AyC4vyB~i3T4AG3EbSO7aCLXup76kWK50PyyVB5JRR8MVYJIRGs14VSXJhPMJyzzOnpIWz5~o1SQNJok0jgTHHyRJBtp3J4Nw7RPNGl2OuWMLhhAldViIG56Z89Dgt1MBjVDOGQ7uDF39VyzSc-SvIgKWzZkHo9TLNGK2bcggWn5MnBaLW7NQmbzt9GyWeMv4ydZCZ~w4Hw518Pbd7AGoffd6krFDM8nhvTzw-9~pwf30VZ3irgiL-BPZCdRISXw__&Key-Pair-Id=APKAJBCGYQYURKHBGCOA)

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
