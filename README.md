# WhichWatch
A Blazor site to demo ActionEquals.com REST API

> If three witches watched three watches, which witch would watch which watch?

## Background Info
ActionEquals.com is Forms-as-a-Service.  It is typically used (especially on static hosting) to submit html forms *somewhere* where they can be stored and retrieved without hassle by setting the **action** attribute to https://actionequals.com/{APIKEY}...
Out of the box features include

- Easy to integrate CAPTCHA (one line of script)
- Registration and Login turn-key use case implementations
- More info, blog, documentation at ActionEquals.com

A sample GitHub Pages site to demo a Contact and Survey form can be interacted with at https://actionequals.github.io

But the ActionEquals service also implements a REST API.  If you think of a "form" as a table schema, then "form submissions" are just records.  Thus, it is possible to "hack" the forms service to use it as a simple database service.

## In This Repo

This is source code for a .NET Blazor WebAssembly site that implements the ActionEquals REST API as its data layer.
The purpose is **not** to recommend publishing such a site where the browser **talks directly** to the service API-- it's merely to show how to implement the API.  In the real world, you would set up your own web service as a proxy to the ActionEquals service so that the credentials are not exposed.

## Special build note

You must edit the /ApiClient/ActionEqualsApiRequest.cs to provide your own ActionEquals account credentials.
See https://www.actionequals.com/blog to find an article about this repo, with screenshots and an explanation of what it's doing.
