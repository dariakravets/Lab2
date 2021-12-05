<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<table border ="1">
					<TR>
						<th>EventName</th>
						<th>PersonName</th>
						<th>Faculty</th>
						<th>Department</th>
						<th>Responsible</th>
						<th>Doer</th>
						<th>Deadline</th>
						<th>Time</th>
						<th>Place</th>
						<th>Characteristic</th>
					</TR>
					<xsl:for-each select="Events/Event">
						<tr>
							<td>
								<xsl:value-of select="@EventName"/>
							</td>
							<td>
								<xsl:value-of select="@PersonName"/>
							</td>
							<td>
								<xsl:value-of select="@Faculty"/>
							</td>
							<td>
								<xsl:value-of select="@Department"/>
							</td>
							<td>
								<xsl:value-of select="@Responsible"/>
							</td>
							<td>
								<xsl:value-of select="@Doer"/>
							</td>
							<td>
								<xsl:value-of select="@Deadline"/>
							</td>
							<td>
								<xsl:value-of select="@Time"/>
							</td>
							<td>
								<xsl:value-of select="@Place"/>
							</td>
							<td>
								<xsl:value-of select="@Characteristic"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
