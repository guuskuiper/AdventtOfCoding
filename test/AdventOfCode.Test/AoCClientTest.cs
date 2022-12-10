﻿using System.Threading.Tasks;
using Xunit;

namespace AdventOfCode.Test;

public class AoCClientTest
{
    [Fact(Skip = "No session file")]
    public async Task<string> Download()
    {
        var response = await AoCClient.DownloadAsync(2022, 5);
        return response;
    } 
    
    [Fact(Skip = "No session file")] 
    public async Task<string> Upload()
    {
        var response = await AoCClient.UploadAsync(2022, 1, true, "TQRFCBSJJ");
        return response;
    }
    
    [Fact]
    public string ParseHtml()
    {
        string text = AoCClient.ParseHtml(Html);
        return text;
    }

    private const string Html = """
    <body>
<header><div><h1 class="title-global"><a href="/">Advent of Code</a></h1><nav><ul><li><a href="/2020/about">[About]</a></li><li><a href="/2020/events">[Events]</a></li><li><a href="https://teespring.com/stores/advent-of-code" tar
get="_blank">[Shop]</a></li><li><a href="/2020/settings">[Settings]</a></li><li><a href="/2020/auth/logout">[Log Out]</a></li></ul></nav><div class="user">guuskuiper</div></div><div><h1 class="title-event">&nbsp;&nbsp;&nbsp;&nbsp
;&nbsp;&nbsp;&nbsp;<span class="title-event-wrap">?y.</span><a href="/2020">2020</a><span class="title-event-wrap"></span></h1><nav><ul><li><a href="/2020">[Calendar]</a></li><li><a href="/2020/support">[AoC++]</a></li><li><a hre
f="/2020/sponsors">[Sponsors]</a></li><li><a href="/2020/leaderboard">[Leaderboard]</a></li><li><a href="/2020/stats">[Stats]</a></li></ul></nav></div></header>

<div id="sidebar">
<div id="sponsor"><div class="quiet">Our <a href="/2020/sponsors">sponsors</a> help make Advent of Code possible:</div><div class="sponsor"><a href="https://aoc.infi.nl/" target="_blank" onclick="if(ga)ga('send','event','sponsor'
,'sidebar',this.href);" rel="noopener">Infi</a> - Bepakt en bezakt gaat de Kerstman eropuit om de cadeautjes te bezorgen. Alles staat al bijna klaar, maar: Passen de pakjes wel in de zak?</div></div>
</div><!--/sidebar-->

<main>
<article><p>That's not the right answer.  If you're stuck, make sure you're using the full input data; there are also some general tips on the <a href="/2020/about">about page</a>, or you can ask for hints on the <a href="https:/
/www.reddit.com/r/adventofcode/" target="_blank">subreddit</a>.  Please wait one minute before trying again. (You guessed <span style="white-space:nowrap;"><code>TQRFCBSJJ</code>.)</span> <a href="/2020/day/1">[Return to Day 1]</
a></p></article>
</main>

<!-- ga -->
<script>
(function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
(i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
})(window,document,'script','//www.google-analytics.com/analytics.js','ga');
ga('create', 'UA-69522494-1', 'auto');
ga('set', 'anonymizeIp', true);
ga('send', 'pageview');
</script>
<!-- /ga -->
</body>
</html>
""";
}