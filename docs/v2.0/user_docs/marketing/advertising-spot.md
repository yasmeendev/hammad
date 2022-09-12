# Adding Advertising Spot

In order to add an advertising spot via Marketing Module, the user should first prepare the dynamic content infrastructure and go through the following steps:  

1. [Create a content item](managing-content-items.md)
2. [Create a content placeholder](managing-content-placeholders.md)
3. [Create published content](managing-published-content.md)

Once the Dynamic content infrastructure is prepared, the user should add the dynamic content to a web site:  

1. Open the web page HTML file.
1. Insert the code into the HTML file, the ID being the placeholder name:

```html
<vc-content-place id="Right banner 240x400" class="col-sm-4 col-md-4 rightblock">
</vc-content-place>
```

In order to add real advertising content, do the following:  

1. Open Marketing Module;
1. Select ‘Dynamic content’ tab;
1. Select ‘Content items’;
1. Select a specific content item from the list, to which the advertising content will be applied;
1. Insert the code into HTML text box and save the changes;
1. The new content will appear immediately on the web page.  

![Fig. Advertising Spot](media/screen-advertising-spot.png)