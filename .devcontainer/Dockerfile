# Use the .NET SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Set the working directory inside the container
WORKDIR /src

# Install the Fantomas tool globally
RUN dotnet tool install -g fantomas

# Set the default command to bash
CMD ["bash"]
