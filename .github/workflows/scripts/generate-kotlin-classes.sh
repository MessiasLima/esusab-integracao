LANGS="kotlin"

for LANG in $LANGS
do
    for FILE in thrift/layout-ras/thrift/*.thrift
    do
        thrift --gen $LANG $FILE
    done

done
