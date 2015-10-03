<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" >

  <xsl:template match="/">
    <html>
      <head>
        <link rel="stylesheet" type="text/css" href="styles.css"/>
      </head>
      <body>
        <table>
          <tr>
            <th>Student</th>
            <th>Gender</th>
            <th>Birth Date</th>
            <th>Phone</th>
            <th>Email</th>
            <th>Course</th>
            <th>Specialty</th>
            <th>FN</th>
            <th>Exams</th>
            <th>Enrollment</th>
            <th>Endorsements</th>
          </tr>
          <xsl:for-each select="students/student">
            <tr>
              <td>
                <xsl:value-of select="name" />
              </td>
              <td>
                <xsl:value-of select="sex" />
              </td>
              <td>
                <xsl:value-of select="birthDate" />
              </td>
              <td>
                <xsl:value-of select="phone" />
              </td>
              <td>
                <xsl:value-of select="email" />
              </td>
              <td>
                <xsl:value-of select="course" />
              </td>
              <td>
                <xsl:value-of select="speciality" />
              </td>
              <td>
                <xsl:value-of select="facultyNumber" />
              </td>
              <td>
                <xsl:for-each select="exams/exam">
                  <div>
                    <strong>Exam: </strong>
                    <xsl:value-of select="name"/> /
                    <strong>Tutor: </strong>
                    <xsl:value-of select="tutor"/> /
                    <strong>Score: </strong>
                    <xsl:value-of select="score"/>
                  </div>
                </xsl:for-each>
              </td>
              <td>
                <strong>Date: </strong>
                <xsl:value-of select="enrollment/date"/> /
                <strong>Exam score: </strong>
                <xsl:value-of select="enrollment/exam-score"/>
              </td>
              <td>
                <xsl:for-each select="endorsements/endorsement">
                  <div>
                    <strong>Teacher: </strong>
                    <xsl:value-of select="teacher-name"/> / 
                    <strong>Endorsement: </strong>
                    <xsl:value-of select="content"/>
                  </div>
                </xsl:for-each>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>