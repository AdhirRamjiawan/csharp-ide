#!/bin/bash

PROJ_DIR=$1
PROJ_NAME=$2
PROJ_TYPE=$3

echo "Creating dotnet $PROJ_TYPE app called $PROJ_NAME in directory $PROJ_DIR..."

pwd

rm -R $PROJ_DIR >& /dev/null

mkdir $PROJ_DIR
cd $PROJ_DIR
dotnet new $PROJ_TYPE

if [ $? -ne 0 ]; then
    echo "Failed to create project."
fi

dotnet build

if [ $? -ne 0 ]; then
    echo "Failed to create project."
fi

dotnet run

if [ $? -eq 0 ]; then
    echo "Successfully created project."
else
    echo "Failed to create project."
fi
