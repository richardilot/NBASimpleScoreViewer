---
title: 'NBA Score App'
disqus: hackmd
---

NBA Simple Score Viewer
===

## Table of Contents

[TOC]

## Guide

How to build and run the app

1. Navigate to ".\NBAScore\bin\Debug\net5.0"
2. Run the "NBAScore.exe" executable
3. Enjoy!

User story
---

```gherkin=
Feature: Guess the word

  # The first example has two steps
  Scenario: Maker starts a game
    When the Maker starts a game
    Then the Maker waits for a Breaker to join

  # The second example has three steps
  Scenario: Breaker joins a game
    Given the Maker has started a game with the word "silky"
    When the Breaker joins the Maker's game
    Then the Breaker must guess a word with 5 characters
```
> I choose a lazy person to do a hard job. Because a lazy person will find an easy way to do it. [name=Bill Gates]


```gherkin=
Feature: Shopping Cart
  As a Shopper
  I want to put items in my shopping cart
  Because I want to manage items before I check out

  Scenario: User adds item to cart
    Given I'm a logged-in User
    When I go to the Item page
    And I click "Add item to cart"
    Then the quantity of items in my cart should go up
    And my subtotal should increment
    And the warehouse inventory should decrement
```

> Read more about Gherkin here: https://docs.cucumber.io/gherkin/reference/

User flows
---
```sequence
User->NBAScore:open app
User->balldontlie API:DoGetTeams: query all teams
balldontlie API->NBAScore:returns JSON query
NBAScore-->User:show list of teams and date picker
User->NBAScore:EventArgs: selected team, date, and clicked search button
NBAScore->balldontlie API:GetGamesAsync: query selected games
balldontlie API->NBAScore:returns JSON query
NBAScore-->User: show the selected games on DataGrid
```

## Sources
1. [StackOverflow](https://stackoverflow.com/)
2. [Avalonia Documentation](http://reference.avaloniaui.net/)
3. [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/?view=net-5.0)
4. Teachers



###### tags:`Documentation`
