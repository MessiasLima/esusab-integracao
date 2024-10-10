LANGS="java:beans"

for LANG in $LANGS
do
    for FILE in thrift/layout-ras/thrift/*.thrift
    do
        thrift --gen $LANG $FILE -out esusab-java
    done

done
