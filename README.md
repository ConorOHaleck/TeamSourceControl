# TeamSourceControl
## Conor's Writeup
### (I'm not sure how to edit the comments previously uploaded by Jacob and I don't want to accidentally delete them)


  We decided to improve our earlier project instead of creating a new one. 
  At first, time spent was mostly on researching how best to implement the many-to-many relationship between armies and soldiers.
  The intent was to have a set, non-changeable set of specific soldiers and their stats, with the intermediate table having a field
  Quantity that would allow for each Army to have a given Soldier and keep track of how many they had. This proved frustrating.  
  
  As soon as I started working on the code, I realized that the many-to-many relationship we had previously coded was going to be
  extremely hard to work with, requiring a lot of joins and some fairly complicated LINQ queries to work correctly. This was due to the
  fact that we had coded the relationship directly, rather than letting ADO.NET generate the appropriate intermediate table. Further work on
  the project would be difficult, and would require a great deal of overhead in the classes for business-logic. So, the majority
  of the time spent on actual code ended up being rewriting and debugging the database code.
  
  The most complex part of the project for me is definitely remembering to use separate commits and branches. Over the course of the
  project I lost a lot of time simply to not remembering to open a new branch, commit correctly, and pull/push branches correctly. 
  When I noticed the flaw in our database code, I initially just started working on fixing it immediately, getting about halfway 
  through doing do when I realized that I had been deleting migrations and adding migrations and removing code and adding code 
  without even thinking about the branch my partner was working on. I contacted him and there didn't end up being a problem, 
  but if I'd gone a little further and pushed those changes, or if he'd been in the middle of something big, there could have been
  a serious problem.
    
    
  
