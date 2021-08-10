Feature: MP-Search

Scenario Outline: MP-Search_Check that user can type, search data by search bar and infotable is shown
	Given Main page was opened
	 When I type '<Query>' in search box
	  And I click search button
	 Then The result page with '<Title>' infotable was opened

	Examples: 
	| Query  | Title  |
	| Google | Google |
	| Яндекс | Яндекс |
	| Убер   | Убер   |