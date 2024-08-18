#!/bin/sh
set -e

if [ "$#" -gt 1 ]; then
  echo "Error: This script accepts zero or one argument only."
  exit 1
fi

if [ "$#" -eq 0 ]; then
  script="src/main.fsx"
else
  script="$1"
fi

dotnet fsi "$script"
