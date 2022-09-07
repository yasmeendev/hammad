# Overview

Virto Commerce Marketing is a dedicated module for managing various marketing activities, campaigns, and promotions you may run within your online store. This section will guide you through its key features and concepts, and will briefly tell you how to work with those.

## Key Features
Virto's Marketing module provides the following key features:
 
+ Managing [dynamic content](#dynamic-content) for Storefront
+ Managing [content publishing](#working-with-dynamic-content)
+ Creating and running [promotions](#promotions)

<!---## Installing Marketing Module
There are two ways with which you can install Virto's Marketing module:

+ *Automatically*: In VC Manager, go to ***Configuration -> Modules -> Marketing module -> Install***
+ *Manually*: Download module ZIP package from [here](https://github.com/VirtoCommerce/vc-module-marketing/releases); then, in VC Manager, go to ***Configuration -> Modules -> Advanced -> Upload module package -> Install***.-->

## Dynamic Content

The Dynamic Content feature allows you to create personalized shopping experiences for customers. Using this feature, you can deliver elements of shopping experience based on a set of conditions or context.

When displaying Dynamic Content to your customers, you will need to consider the following:

* Type of content you are going to display
* Target audience who will see the content
* Time frame within which the content will be visible
* Content location (which part of the webpage will house the content in question)

Dynamic Content is configurable through Virto Commerce Platform Manager, which means your marketing team can set it up without any developer or system admin effort. For images or Flash animations, they may need a graphic designer to create a file and upload it to Assets. However, once this is done, marketing can configure rules for displaying content without any assistance from technical teams.

Dynamic Content consists of four independent components:

+ ***Dynamic Content***
+ ***Content Publishing***
+ ***Content Type***
+ ***Content Placeholder***

The first two components, ***Dynamic Content*** and ***Content Publishing***, can be configured through Virto Commerce Platform Manager by the marketing team members. Dynamic Content provides a name and a description of the type of content to be displayed, while the Content Publishing object specifies when, under what conditions, and where the Dynamic Content will appear.

The ***Content Placeholder*** is also created via Virto Commerce platform manager, but they are created by developers, web designers and system management personnel. As soon as the  web developer adds the Content Place to a template, the developer or another user with appropriate permissions must register it in Virto Commerce platform manager.

The ***Content type*** is a template used to define the Dynamic Content Type. It describes how a particular content type is displayed and what information is required for it to be displayed. Virto Commerce includes several Content types for the most common types of Dynamic Content. For example, there is a Content type to display images with links (banner). Another one to display product data (product with image and price).

The following Dynamic ***Content Types*** are shipped with Virto Commerce out-of-the-box. Each of them requires one or more parameter values to specify things such as: what image file should be displayed or what the target web page should display after clicking on the element.


| Content type | Description | Parameters |
|--------------|-------------|------------|
|Flash | Displays an animated Flash file that cycles through three images. This Flash animation shows each of three images in succession, each having a clickable link that shows the shopper a different promotion. You will need to specify the URLs for each link within the Flash file.| FlashFilePath - path to the Flash animation file, Link1Url, Link2Url, Link3Url - enter the complete URL to the target page (item, promotion etc)|
| Html | Displays HTML content | RawHtml - enter raw Html formatted text here |
|ImageClickable |Displays an image that can be clicked to perform some action. For example, redirect to another page, product or promotion |Alternative text - text if the image can not be displayed. ImageUrl - link to the image. TargetUrl - link to the target when image clicked. Title - text (optional) |
| ImageNonClickable |Displays an image. For example, use this type to alert customers to a shopping cart promotion that will give them a discount on checkout |Alternative text - text if image can not be displayed. ImageFilePath - path to the image file |
|ProductsWithinCategory |Displays products of the category as slideshow |Category code - code of the category. Title - user friendly title of the category. Item count - how many items will be presented in the slideshow. New items - switch to show only new items.|

### Tags

The Dynamic Content functionality can be used to show specific content to targeted customers. The system determines the customers properties via Tags. Virto Commerce incorporates tagging system that is used to set and evaluate tags that the user can use to segment Customers, and to decide when, where and to which Customer this content should be displayed.

The tagging data about a customer is captured in a variety of ways, including the following:

1. Information provided in a registered customer account;
1. Information entered by a Customer Service about a customer during the customer's service call;
1. Target and referring URLs and search terms captured when the user clicks a link that brings them to a storefront;
1. Customer Geo location.

Information captured by the tags is stored in the user’s session while he shops in on storefront. The information can then be used to evaluate whether the customer meets the conditions set for displaying the Dynamic Content. Tag information is captured only when the customer first visits the storefront during the browser session.

A Marketer or other Manager user with granted Dynamic Content permissions, uses the tags when creating conditions that determine whether a customer will see a piece of Dynamic Content or not.

!!! tip
	Refer to [this article](publishing-conditions.md) if you want to learn more about publishing conditions.

### Working with Dynamic Content

Once created, the Dynamic Content can be reused as many times as required in Content Publishing items.

Creating ***Dynamic Content*** in Virto Commerce management application specifies what Content to deliver (e.g. Image, Clickable image, Flash etc.) and setting up its parameters.

Creating ***Content Publishing*** specifies which Dynamic Content(s) to view and under which conditions the Dynamic Content should be available.

!!! warning
	Dynamic Content will not be available on the front end until it is assigned to any of the Content Publishing items.

For more information on managing content, please refer to these dedicated guides:

[Managing Content Items](managing-content-items.md)

[Managing Content Placeholders](managing-content-placeholders.md)

[Managing Content Publishing](managing-content-publishing.md)

### Adding Advertising Spot

In order to add an advertising spot via Marketing Module, the user should first prepare the dynamic content infrastructure and go through the following steps:  

1. Create a content item.
1. Create a content placeholder.
1. Create a content publishing.  

Once the Dynamic content infrastructure is prepared, the user should add the dynamic content to a web site:  

1. The user should open the web page HTML file;
1. Insert the code into the HTML file. The ID is the placeholder name:

```html
<vc-content-place id="Right banner 240x400" class="col-sm-4 col-md-4 rightblock">
</vc-content-place>
```

In order to add a real advertising content, do the following:  

1. Open Marketing Module;
1. Select ‘Dynamic content’ tab;
1. Select ‘Content items’;
1. Select a specific content item from the list, to which the advertising content will be applied;
1. Insert the code into HTML text box and save the changes;
1. The new content will appear immediately on the web page.  

![Fig. Advertising Sport](media/screen-advertising-spot.png)

## Promotions

***Promotion*** is a marketing tool used to increase sales. Promotions are store-specific and cannot be shared across multiple stores. To create a promotion, you must have the ***Manage promotions*** permission.

!!! warning
	In order to apply a promotion to multiple stores, you will need to manually recreate it for each relevant store.

For more information on managing promotions, please refer to these dedicated guides:

[Promotion Rules](promotion-rules.md)

[Managing Promotions](managing-promotions.md)

[Combining Active Promotions](combining-active-promotions.md)