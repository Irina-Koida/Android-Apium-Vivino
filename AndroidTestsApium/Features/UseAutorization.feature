Feature: UseAutorization
As a user
I want to autorized in the Sign in page
In order to get access to choose and buy wine

Scenario: Check personal account opens when I do autorization
  When I tap I have an account button
  Then Welcome Back page with text "SIGN IN WITH EMAIL" opens 
  When I tap Email field 
  When I put personal emai "marineriscr@gmail.com"
  When I tap on Password field
  When I put password "14"
  When I tap on Log in button 
  Then For you page with title "Picked for you" opens 

Scenario: Check product card opens in list of Browse Wines Types
  When I tap I have an account button
  Then Welcome Back page with text "SIGN IN WITH EMAIL" opens 
  When I tap Email field 
  When I put personal emai "marineriscr@gmail.com"
  When I tap on Password field
  When I put password "14"
  When I tap on Log in button 
  When I tap Search item
  When I tap Type item
  When I tap Red type
  When I tap first product card 
  Then Product card with title "Bramare Malbec Lujan de Cuyo 2019" opens
  When I tap on Calculate your personal match button
  Then Message window with title "You’re a mystery to us" opens

Scenario: Check product card opens in list of pairing wine for beef 
  When I tap I have an account button
  Then Welcome Back page with text "SIGN IN WITH EMAIL" opens 
  When I tap Email field 
  When I put personal emai "marineriscr@gmail.com"
  When I tap on Password field
  When I put password "14"
  When I tap on Log in button 
  When I tap Search item
  When I tap Pairing item
  When I tap Beef type
  When I tap first wine product card 
  Then Product card with vino name "Bramare Malbec Lujan de Cuyo 2019" opens
  When I tap on Buy button
  Then Message with title "6 Bottles" opens
  When I tap to minus button
  Then Message  with title "5 Bottles" opens
  When I tap to plus button
  Then Message  with title "6 Bottles" opens

Scenario: Check search of wines in Browse Wines page
  When I tap I have an account button
  Then Welcome Back page with text "SIGN IN WITH EMAIL" opens 
  When I tap Email field 
  When I put personal emai "marineriscr@gmail.com"
  When I tap on Password field
  When I put password "14"
  When I tap on Log in button 
  When I tap Search item
  When I tap Search field
  When I input "Rosso" 
  When I tap Search button
  When I tap for second wine in list for search
  Then Search result "Memoro Rosso" opens 

Scenario: Checking added wine in basket for purchase
  When I tap I have an account button
  Then Welcome Back page with text "SIGN IN WITH EMAIL" opens 
  When I tap Email field 
  When I put personal emai "marineriscr@gmail.com"
  When I tap on Password field
  When I put password "14"
  When I tap on Log in button 
  When I tap Search item
  When I tap Search field
  When I tap on My Wines item menu
  When I tap on added wine
  When I tap on bottle of wine
  When I tap buy button
  When I tap Add to cart button
  Then Order with name of wine "Upper Barn Chardonnay 2017" opens 
  #Then Order with total price "$257.38"of wine opens

