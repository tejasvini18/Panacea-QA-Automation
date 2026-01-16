# QA Automation Task – Panacea Applications

## Overview
This project contains a QA automation test suite created as part of the
Panacea Applications QA Automation Engineer assessment.

The objective of this task is to demonstrate a clear, maintainable, and
professional approach to test automation using C#, Selenium WebDriver,
and NUnit, with a strong focus on quality, reliability, and communication
rather than test quantity.

## Application Under Test
https://automationintesting.online/

This website represents a hotel booking application where availability,
stability, and responsiveness are critical for business success.

## Tools & Technologies
- C#
- .NET SDK
- Selenium WebDriver
- NUnit
- ChromeDriver (managed via NuGet)

The selected tools align with the existing automation stack used by
Panacea Applications and follow modern automation best practices.

## Automation Test Suite
The automation test suite focuses on **smoke-level validation** to ensure
that the application is functioning correctly at a basic but critical level.

The suite includes 20 automated tests that validate:

- Successful page load
- Correct URL navigation
- Page title availability
- Core HTML structure (html, head, body)
- Page content stability
- Browser session health
- Page responsiveness and integrity

Dynamic or brittle UI assertions were intentionally avoided to ensure the
tests remain stable, reliable, and suitable for execution in CI/CD
environments.

## Test Strategy – Quality Over Quantity
Rather than creating a large number of fragile UI tests, this framework
prioritises high-value smoke tests that provide fast feedback and high
confidence that the application is usable.

This reflects real-world automation practices where reliability,
maintainability, and execution speed are more important than sheer test
count.

## Framework Design
- Follows Page Object Model principles
- Clear separation of concerns (Tests, Pages, Utilities, Config)
- Reusable WebDriver setup via a central DriverFactory
- Proper resource cleanup using NUnit TearDown
- Easily extendable for future test coverage

## Project Structure
AutomationTesting/
├── Drivers/
├── Pages/
├── Tests/
├── TestData/
├── Utilities/
├── Reports/
├── Config/
└── README.md


## How to Run the Tests
1. Install the .NET SDK
2. Open a terminal in the project root folder
3. Run the following command:

   dotnet test

ChromeDriver is managed automatically via NuGet, so no manual driver
download or configuration is required.

## Known Limitations
- End-to-end booking flow validation is not included
- Cross-browser testing is not implemented
- API-level testing is not part of this suite

These items were intentionally excluded to keep the solution focused,
concise, and aligned with the scope of the task.

## Future Improvements
With additional time, this framework could be extended to include:
- End-to-end booking journey tests
- API automation for backend validation
- Cross-browser execution
- CI/CD pipeline integration
- Enhanced reporting and logging

## Conclusion
This automation solution demonstrates a pragmatic and professional
approach to test automation, focusing on reliability, clarity, and
maintainability. The framework is designed to be easy to understand,
review, and extend by a QA or engineering team.