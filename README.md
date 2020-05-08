# _Epicodus C# Pierre's Bakery_

#### _Date: May 8th, 2020
#### By _**Jason Macie**_

## Description

_This is an application that will show the user all available goods at a bakery. The user can then specify a checkout amount of items to purchase, with a resulting cost display at the end._

## Setup/Installation Requirements

This program requires .NET to be installed.
* Clone this repository
* Navigate to the repo in command console
* Run: dotnet build
* Run: dotnet run

## Specs

### MVP

* Prompt the user with a welcome message that describes they are in a bakery, the goods the bakery is selling, and their costs.
* Create two seperate classes to handle the data manipulation of breads and pastries. Each product has it's own specific sale.
  * Bread Sale: Buy 2, get 1 free. A single loaf costs $5.
  * Pastry Sale: Buy 1 for \$2 or 3 for $5.
* Allow the user to choose the amount of bread and or pastries they'd like to purchase. Once they are done, print out a message that displays the items selected, and the total cost.
  * Input: Bread 3, Pastries 2
  * Output: Checkout:
            Item     Qty  |   Cost
            --------------------
            Bread:    3   |   $10
            Pastries: 2   |   $4
            --------------------
            Total:            $14

### Additional Features

* Calculate total taxes as well as a tip display below the total (Washington state rates).
* Offer more goods to the user.
* Update the console to have colors, and a better display.

## Known Bugs

No known bugs as of 5/8/2020

## Technologies Used

* .NET

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Jason Macie_**
