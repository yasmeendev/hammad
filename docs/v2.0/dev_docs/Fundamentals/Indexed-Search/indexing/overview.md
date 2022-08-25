# Indexing Overview

Common Indexing is a search engine agnostic process for data indexation.

The process chart of such indexing may look as follows:

![Common indexing process structure](media/01-common-indexing-process-chart.png)

To do indexing, the process performs the following steps:

1. IndexingManager starts the indexation process for every affected entity in a scope of the specific document types that is requested

2. Requests the list of changed entities identifiers that has to be indexed, by executing IIndexDocumentChangesProvider  at the specific date for Incremental indexation or all  entities for Overall index rebuild. 

3. Gets the resulting Index documents for entities identifiers by calling IIndexDocumentBuilder instances

4. Collects index documents and saves them in search index storage through ISearchProvider.

The key indexing features are:

+ Specialized UI and API in platform manager  for routine tasks with indexing. <!---(TODO: Link indexation in platform manager)-->

+ Index document enrichment: You can compose a index document from fields are taken from different data source <!---(TODO: Link how to create a new indexer# Enrichment )-->

+ Custom  indexers: When developing an indexer, you'll specify a Data source and a Search index (destination). Currently the process of defining new indexer is required development <!---(TODO: Link how to create a new indexer)-->  Also, thanks to search engines agnostic you create custom indexer only once and it will works with all search providers with no changes.

+ Manual and incremental index updates: You can run indexers on demand or on a recurring basis,  Virto updates search indexes by periodically adding or removing data entities that have changed in the Commerce Engine. Thanks to incremental index updates, the search engine  updates the  indexes with index documents  based on new, changed, or deleted  items in data sources. <!---TODO: Link Incremental index updates-->

+ Blue/Green indexing: Allows you to perform for zero downtime upgrades of your index. You can execute a full index rebuild or long time indexation tasks on the another index instances  and switch them to published index that production environment is connected to when these tasks are finished.<!---TODO: Link Blue/Green indexing-->