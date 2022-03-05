
## Team name
⟹ Turing

## Category
⟹ Best addition to the Sitecore MVP site

## Description
⟹ The addition we're offering here is **MVP Review Portal** in which we can have the whole reviewing process. 

This new feature [Reviews] will offer the following:
- **Submissions Listing**: Which is a page that display all submission (possible with facets like Country, Category...etc), this page will be secured and accessable via site admin. 
- **Submission Detail**: Which is a page that can be accessed through the above listing page, in which we can see the detailed of the submission (MVP application Submission) like personal information, Objectives and Motications, community profiles, Online and Offline Contributions in addition to the following reviewing panel
- **Reviewing Panel**: Its a section in the submission detail in which the site admin can assign reviewers to an application/submission. we have three types of reviewers (MVP reviewer, Corporate Reviewer and Regional Reviewer)
- **Review Status/Feedback**: In this section the reviewer can add his/her feedback, which includes a status (Yes, No, Maybe) in addition to the reason for choosing the status. 


## Video link
⟹ Provide a video highlighing your Hackathon module submission and provide a link to the video. You can use any video hosting, file share or even upload the video to this repository. _Just remember to update the link below_

⟹ [Replace this Video link](#video-link)


## Installation instructions
⟹ Write a short clear step-wise instruction on how to install your module.  

- Make sure you have an installation of the sitecore MVP website, can be found [here](https://github.com/Sitecore/MVP-Site)
- Or, If you're using this repo, you can just following the instruction [here](https://github.com/Sitecore-Hackathon/2022-Turing#readme)
- Sitecore Changes can be either sync through CLI, you can run `dotnet sitecore ser push` from `main` branch, or you can use the following sitecore packages
    - [Review Feature - MVP Website System Items-1.0](https://github.com/Sitecore-Hackathon/2022-Turing/blob/main/sc.packages/Review%20Feature%20-%20MVP%20Website%20System%20Items-1.0.zip)
    - [Reviews Feature -MVP Website Data Lookups-1.0](https://github.com/Sitecore-Hackathon/2022-Turing/blob/main/sc.packages/Review%20Feature%20-%20MVP%20Website%20System%20Items-1.0.zip)
    - [Review Feature - MVP Website Content Pages-1.0](https://github.com/Sitecore-Hackathon/2022-Turing/blob/main/sc.packages/Review%20Feature%20-%20MVP%20Website%20Content%20Pages-1.0.zip)
- Code Changes, you would need to publish solution code, you can just rebuild solution. 



## Usage instructions
⟹ Provide documentation about your module, how do the users use your module, where are things located, what do the icons mean, are there any secret shortcuts etc.

The feature has the following user types:
- Applications/Submissions admin: responsible for assigning reviewers to applications/submissions
- Applications/Submissions Reviewer: responsible for reviewing applications/submissions and provide feedback

Once the admin is logged in to the system, admin can use the `/Submissions` page to access a listing page of all submissions, this page is **utilizing GraphQL endpoint** for seaching and retrecing applications/submissions. following is a screenshot for this page: 

![Hackathon Logo](docs/images/Submissions-Listing.png?raw=true "Submissions Listing")

The admin can use the open beside each each submission to enter the details page, in which the admin can use the Review Panel to assign reviewers,currently the system has three type of reviewers:
- MVP reviewer 
- Corporate Reviewer 
- Regional Reviewer 

Following is a screenshot from the application/submission detail page showing the content in addition to the Review admin panel:

![Deal With It](docs/images/Assign-Reviewers.png?raw=true "Assign Reviewers")


The reviewer user can also utilizing the same listing and details pages, the page will also filter the submission based on the **logged In User**, showing the submissions that the user can see, then the reviewer user can review and provide feedback through a simple form as you can see from the following screenshot:

![Deal With It](docs/images/Reviewer-Feedback.png?raw=true "Reviewer Feedback")

## Comments

This is a basic start of the Review Portal, it still needs to be worked on, here are areas of improvments and additions: 
- Ability to multiselect submissions and assign reviewers. 
- Ability to assign reviewers per Category or Country.
- Adding facets to the submissions listing page like Country, Category..etc.  
- Create reports by category, country, company..etc.
