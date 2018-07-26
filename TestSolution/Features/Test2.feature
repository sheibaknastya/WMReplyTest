Feature: Test2
	The purpose of this test is to check http://todomvc.com/examples/angularjs/#/

	And fix the issues:
	• No folder/namespace structure. Everything at the root.
	• Feature files are in an imperative style rather than declarative (they describe specific steps, not behaviour).
	• The code is inconsistently formatted.


Scenario: POSTIVE Add task to the list
	Given Testing URL is opened
	When The user adds 'test' as a task
	Then 'test' is added to the list
	When The user adds 'test2' as a task
	Then 'test2' is added to the list
	When The user adds 'test3' as a task
	Then 'test3' is added to the list

Scenario: NEGATIVE Add task to the list
	Given Testing URL is opened
	When The user adds 'test' as a task
	Then 'test' is added to the list
	When The user adds 'test2' as a task
	Then 'test3' is added to the list
