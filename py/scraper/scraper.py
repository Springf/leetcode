import scrapy

class AirTicketSpider(scrapy.Spider):
    name = "airticket_spider"
    def start_requests(self):
        urls = [
            'http://www.huasing.org',
        ]
        for url in urls:
            yield scrapy.Request(url=url, callback=self.parse)

    def parse(self, response):
        page = response.url.split("/")[-2]
        filename = 'huasing-%s.html' % page
        with open(filename, 'wb') as f:
            f.write(response.body)
        self.log('Saved file %s' % filename)