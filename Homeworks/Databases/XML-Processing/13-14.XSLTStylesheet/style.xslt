<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Albums Catalogue</h1>
        <ul>
          <xsl:for-each select="catalogue/album">
            <li>
              <div>
                <strong>Name: </strong>
                <xsl:value-of select="name" />
              </div>
              <div>
                <strong>Artist: </strong>
                <xsl:value-of select="artist" />
              </div>
              <div>
                <strong>Year: </strong>
                <xsl:value-of select="year" />
              </div>
              <div>
                <strong>Producer: </strong>
                <xsl:value-of select="producer" />
              </div>
              <div>
                <strong>Price: </strong>
                <xsl:value-of select="price" />
              </div>
              <div>
                <strong>Songs: </strong></div>
              <ul>
                <xsl:for-each select="songs/song">
                  <li>
                    <div>
                      <strong>Title: </strong>
                      <xsl:value-of select="title" />
                    </div>
                    <div>
                      <strong>Duration: </strong>
                      <xsl:value-of select="duration" />
                    </div>
                  </li>
                </xsl:for-each>
              </ul>
            </li>
          </xsl:for-each>
        </ul>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
