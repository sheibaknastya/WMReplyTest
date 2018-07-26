Feature: Test
	The purpose of this test is to check http://todomvc.com/examples/angularjs/#/

Scenario: POSTIVE Add task to the list
	Given I open testing URL
	When I add 'test' as a task
	And I press enter
	Then 'test' is added to the list
	When I add 'test2' as a task
	And I press enter
	Then 'test2' is added to the list
	When I add 'test3' as a task
	And I press enter
	Then 'test3' is added to the list

Scenario: NEGATIVE Add task to the list
	Given I open testing URL
	When I add 'test' as a task
	And I press enter
	Then 'test' is added to the list
	When I add 'test2' as a task
	And I press enter
	Then 'test3' is added to the list
