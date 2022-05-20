# vstemplate-webapi-clean-architecture
Microsoft .NET Core WebApi - a Visual Studio Template that generates basic scaffolding for small to mid-sized projects

I find myself doing a lot of innovation work, creating small proof-of-concepts and spinning up apps and services at a moderately fast rate. 
This can get really frustrating if you want to implement services using Clean Architecure. Writing a webservice that has four endpoints ... and yet spending most of your time creating folders and interfaces ... is sub-optimal.  :)  

There's always the option of writing throw-away code, but many of our POCs live(d) on for months - even years - and that "throw-away" code became part of the enterprise. Icky.

Never having created Visual Studio templates before, decided to give it the ol' college try, and see if this helped minimize startup friction.

General instructions:
The zipped-up template should be placed in: %userprofile%\documents\visual studio 2022\templates\projecttemplates

The next time you start Visual Studio 2022, it should pick up the custom project template, and allow you to select it.

Whatever you type in for the Project Name (for the sample I used "Rammstein15") will be inserted where it needs to go throughout the solution. The template generates a Visual Studio solution with two Solution Folders at the top level: "src" and "tests".  Under "src" there will be a set of 4 projects that are a fairly decent start at a Clean Architecture implementation.  We do a lot of weird stuff for our unit tests, so I left that blank for whatever you might use.

<img width="274" alt="image" src="https://user-images.githubusercontent.com/105896248/169442074-e50c1827-9021-4b3c-b093-1634581c395e.png">
