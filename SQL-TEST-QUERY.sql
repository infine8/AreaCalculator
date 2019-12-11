SELECT a.Theme ArticleTheme, t.Name TagName 
FROM Article a
LEFT JOIN TAG t ON a.TagId = t.Id