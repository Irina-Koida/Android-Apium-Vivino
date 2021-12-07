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

