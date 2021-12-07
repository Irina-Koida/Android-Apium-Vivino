Feature: UseAppWithoutRegistering
	As a user
	I want to use the Vivino mobile app without registration
	In order to familiarize yourself with the application and understand if I will use it

Scenario: Go to the start page without registration
	When I tap a "Try us out" button
	When I tap "Next" button
	When I tap "Next" button
	When I tap the "Next" button
	When I tap to "Next" button
	When I select a "Continue without account" button
	Then My profile page is open

Scenario: It is possible to navigate to the selected wine
    When I tap a "Try us out" button
	When I tap "Next" button
	When I tap "Next" button
	When I tap the "Next" button
	When I tap to "Next" button
	When I select a "Try us out" button
	When I tap Search section
	When I tap "Red" type
	Then I see a info text "Red"
	Then I see text with the count of wines "521 wines"

Scenario: It is possible to navigate to the selected combination of something with wine
    When I tap a "Try us out" button
	When I tap "Next" button
	When I tap "Next" button
	When I tap the "Next" button
	When I tap to "Next" button
	When I select a "Try us out" button
	When I tap Search section
	When I tap "PAIRING" subsection
	When I tap "Lamb" pair
	Then I see a information text "Lamb"
	Then I see a text with the count of wines "344 wines"

Scenario: It is possible to navigate to the selected wine style
   	When I tap a "Try us out" button
	When I tap "Next" button
	When I tap "Next" button
    When I tap the "Next" button
	When I tap to "Next" button
	When I select a "Try us out" button
	When I tap Search section
	When I tap subsection "STYLE"
	When I tap "Californian Cabernet Sauvignon" style
	Then I see a text "Californian Cabernet Sauvignon"
	Then I see text with the count of selected wines by style "1 wine"

Scenario: It is possible to navigate to the notifications page
   	When I tap a "Try us out" button
	When I tap "Next" button
	When I tap "Next" button
	When I tap the "Next" button
	When I tap to "Next" button
	When I select a "Try us out" button
	When Tap the Notifications icon, it looks like a bell in the upper right corner
	Then I see text "You have no notifications"