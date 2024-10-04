#!/bin/bash

PROJ_DIR=$1
PROJ_NAME=$2
PROJ_TYPE=$3
IDE_LOG=ide-log.txt

echo "Creating dotnet $PROJ_TYPE app called $PROJ_NAME in directory $PROJ_DIR..." >> $IDE_LOG

cd $PROJ_DIR
mkdir $PROJ_DIR
dotnet new $PROJ_TYPE >> $IDE_LOG

if [ $? -eq 0 ]; then
    echo "Successfully created project." >> $IDE_LOG
else
    echo "Failed to create project." >> $IDE_LOG
fi
