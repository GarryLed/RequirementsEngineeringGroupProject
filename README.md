# Requirements Engineering Group Project
## Presentation 
## Part 1: 

### Introduction 
 

Our app is a Study helper/ Event’s app for students who attend ATU. It has many features which will help improve the lives of university students.
One of the major features of the app is an event joining and creating feature. 
It includes an online noticeboard which shows all events coming up soon and an area to learn about finished events.
Users who wish to join events can input in the app which category’s they like (sport, meetups, yoga, etc.) and will receive notification’s when an event they may like gets posted. There is also an easy to use “Event Maker” tool.




Additionally, a lot of students, especially those with learning disabilities like ADHD, struggle with time management and staying on top of their college workload. 
Trying to manage multiple courses, assignments and continuous assessments can be overwhelming.
The app will also help students by sending push notifications directly to their phone, reminding them of upcoming classes, assignment deadlines, and exam dates, so they can keep up to date with their responsibilities without having to search the ATU website for information.  
Additionally, the app will allow students to track study time, set daily study goals, and see how much study time they are spending on each course, which can help manage their study time better.



Lastly, our app is a study helper and events platform created for ATU students, created to simplify academic tasks and increase people's social interaction via events. Features include an event discovery and creation tool, where students can view and receive notifications about events that they are interested in, like sports, coding, dancing, music etc.... The app also includes an event maker for easy event creation.
For studying, the app offers tools to help manage your time, sending notifications for upcoming classes, deadlines, and exams. International students and those managing busy schedules or conditions like ADHD can benefit from this app greatly by helping them set goals, keep track of study hours, and stay organized. This app enables ATU students to stay on top of responsibilities and meet others with shared interests.


## User Personas

### Bob - second year computing student  
 
Bob is a second year Computing student, who has a learning disability (ADHD), and wants a way to keep track of his study time, course work, assignments due, and exams dates throughout the semester.   
If he could receive notifications to his phone about approaching class times and room location, assignments due and upcoming CA exams, this would relieve a lot of stress and time spent looking for class timetables, and exam dates on the ATU website.  
It would also be helpful if he could track his daily study time on a time tracking app, which would allow him to create estimated time needed to study for a particular assignment, set up daily study goals, and track his overall time spent studying, which would alleviate the pressure of underestimating the study time needed for each course, which often leads to leaving assignments to the last minute. 

### Adam – Fourth Year Student – Event Organizer

Adam is a fourth-year student who works for the “University Event’s Board". He’s the head of event creation and often creates events for anyone in his age group who attends ATU.
He wants a simple platform to post the events he makes and let people join his events easily without having to spend extra time collecting RSVPs or add people to a list manually.
As someone who creates events of all kinds and categories, he would also love if people could follow the specific categories they like and get notifications when he posts a new event he makes.
He also wants an online notice board of sorts, which lists every event coming up and lets people learn about events that happened before.


### Christina First year international student 

Christina is a first-year international student studying at ATU Sligo.  She’s trying her best to adjust to a new country while also balancing her studies and making new friends.  She wants to try keep up with any social events whilst also organising her studies to keep up with her busy timetable.
She’s looking for an app that lets her discover on-campus events specifically aimed at all types of students. She also needs help staying on top of her coursework, especially because she’s still adjusting to the academic calendar and deadlines at ATU.
She wants help finding events relevant to international or new students.

## User Stories 

### Bob's User Stories 

- As a student I want to be notified about upcoming classes and or exams/CA’s daily, so I don’t miss a deadline or exam.
- As a student, I want to track my study time, so I can reduce stress and see how much time I am allocating to each course on a weekly basis.
- As a new student, I want to receive event suggestions that match my personal interests so i can meet new people

### Christina's User Stories 
 
- As a student, I want to set study goals and get reminders to meet them, so I can stay motivated
- As a student, I want to set notifications for study breaks or reminders to take a break, so I can manage my study sessions and avoid burnout.

### Adam's User Stories 
- As a student I would like an app to help me create and let people know about events I organize so people who have similar interests to me can join my events. 
- As a student I would like an app that sends me updates on events going on near me so I can meet people with similar interests and make new friends at events  
8.	As a student I would like to filter between categories of events, so I can choose if I want a relaxing/ social event, or a fun/ sporty/ active event.

## Going deeper into the User Stories (adding acceptance criteria/ tests for various scenarios)

### Starting with Bob

**As a student I want to be notified about upcoming classes and or exams/CA’s daily so I don’t miss a deadline or exam.** 
 
**Acceptance criteria/tests** 
•	User is notified about upcoming classes and events  
•	A user cannot receive notifications about upcoming events without opting in to accept notifications  
•	Notifications can be turned on or off by the user  
•	User can decide which events to receive notifications from  
 
**Scenarios**  
Scenario: Getting notifications for upcoming classes  
•	Given I am a registered user of the app  
•	When I have an upcoming class  
•	Then I am sent a notification to my phone with the time and class location  
 
Scenario: Getting notifications for upcoming CA exams and/or assignments due   
•	Given I am a registered for a class  
•	When I have an upcoming exam  
•	Then I am sent a notification to my phone about exam time and location  
 

**As a student, I want to track my study time, so I can reduce stress and see how much time I am allocating to each course on a weekly basis.** 
 
**Acceptance criteria/tests** 
•	Student can create study block in Calander and track time for all events  
•	Tracked time is stored in a database and displayed on a time tracker dashboard for user  
•	Time tracking can be ascending or descending order  
•	Optional bell rings when timer ends to remind user session has ended 
•	User is notified if timer is left on for extended periods 
•	Time tracking and goal reports are available on analytics page  

Scenario: Tracking study time  
•	Given I am on the study time tracker page 
•	When I click the “start timer” button  
•	Then I am shown the timer for my current study session  
 
Scenario: Setting study goals  
•	Given I am on the study tracking page  
•	When I click on “Create study goal”  
•	Then a popup window appears that allows me to enter a goal name, and the least number of hours I want to study for, daily. 

### Now onto Christiana
User Stories 
As a student, I want to be able to track my mood throughout the day so I can track my wellbeing over time.
Acceptance Criteria
•	The student must be able to log their mood throughout the day.
•	The app should send reminders at the end of the day if their mood has not been logged.
•	The app should display mood trends on weekly and monthly charts.
**Scenarios**
Mood Logging Reminder
•	Given the student has not logged a mood by 9 pm on any given day,
•	When the day is close to ending,
•	Then the app sends a notification to remind the student to log their mood.

**Mood Trends**
•	Given the student has logged their mood over the last week,
•	When the student opens the mood tracking section,
•	Then the app displays a weekly or monthly chart showing mood trends, including the number of positive, neutral, and negative days.


**As a student, I want to include mental health breaks (e.g walks, meditation) in my schedule to maintain a good balance between academics and self-care.**

**Acceptance Criteria**
•	The student must be able to schedule mental health breaks (e.g., meditation, journaling, exercise).
•	The app should automatically recommend breaks based on the student’s workload.
•	The app should notify the student of upcoming breaks.

**Scenarios**
Suggesting Breaks Based on Schedule
•	Given the student has entered their class and work schedule,
•	When the app detects free time between events,
•	Then the app suggests optimal time slots for scheduling a mental health break.
Break Reminder Notification
•	Given the student has scheduled a mental health break,
•	When the scheduled time for the break is approaching,
•	Then the app sends a notification reminding the student to take their break.


### And Lastly Adam 
**As a student I would like an app to help me create and let people know about events I organise so people who have similar interests to me can join my events.**

 **Acceptance criteria/tests** 
•	User can enter the name, description, time and date of their event 
•	If the user’s event doesn’t fit into a category, they can add a new category 
•	User can’t create an inappropriate event 
•	User can enter the minimum amount of people needed for the event to go ahead 
•	Event will be added to the events tab of the app 

**Scenario: Making an event:** 
•	Given the user is someone who wants to create an event 
•	When the user clicks the "Create Event" button 
•	Then the user can enter all the details about their event (name/category/time/place etc.) 
     
**As a student I would like an app that sends me updates on events going on near me so I can meet people with similar interests and make new friends at events.**  
**As a student I would like to filter between categories of events, so I can choose if I want a relaxing/ social event, or a fun/ sporty/ active event.** 

**Acceptance criteria/tests:** 
•	User can enter the distance away they want an event to be for them to receive a notification 
•	User will only receive notifications about category's they like, as long as they choose the categories they like 
•	If they choose to not pick their favourite categories, all categories will automatically be chosen 
•	An option between phone notifications/ emails/ or both is given to the user 
•	3 options are given to the user in the notification “Join”, “Learn More”, “Remind me later”, and “Decline”.
 
**Scenario: Joining an event:** 
•	Given the user enters in the app that they like sport (or any other category of events) 
•	When a sporting event is happening near the user 
•	Then a sporty notification is sent to the user (⚽ Are you ready to win? Join {event} today! ⚽) 

•	Given the user doesn't enter any events that they like, and the user doesn't say that they like all events 
•	Then the app prompts the user to add events they like from a list of options 
•	Then events will be sent to the user 
 
**Best Case Scenario:** 
•	User opts in to receiving updates about events happening in their local area 
•	User enters where they are living/staying and what type of events they like (music, sport, yoga, casual meetups etc.) 
•	App automatically sends a notification when a relevant event is happening near to the user 
•	User clicks the notification and learns more about the event 
 
**Worst Case Scenario:** 
•	User enters a distance of wanted updates too low, so no events are close enough to the user 
•	App prompts the user to increase the distance of wanted updates 
•	User increases the distance and then receives notifications


## Initial Wireframes and Use Case Diagrams based on the above information 

### Bob: 

**As a student I want to be notified about upcoming classes and or exams/CA’s daily  so I don’t miss a deadline or exam.**

![image](https://github.com/user-attachments/assets/19294681-1da2-4880-9854-9043525945cc)

**As a student, I want to track my study time, so I can reduce stress and see how much time I am allocating to each course on a daily/weekly basis.**

![image](https://github.com/user-attachments/assets/421f4580-4b8f-443a-b842-c6152e2e3840)

### Use Case Diagrams 
![image](https://github.com/user-attachments/assets/6f9d5d90-d1d3-4d29-bb3a-0d764d1de1af)


### Christina
**Tracking Moods Trends**

![image](https://github.com/user-attachments/assets/58c9236b-2851-4c01-b111-cd9dab4ae297)  ![image](https://github.com/user-attachments/assets/1ff1d9f8-e81b-4521-9eee-7948a77e9988)

### Adam:

**Notification sent about an event:      Browse Existing Events:                         Create Events:**

![image](https://github.com/user-attachments/assets/253edf19-0d48-4f3a-8f1f-f8d708ce8e6b)     ![image](https://github.com/user-attachments/assets/a1999aa0-9117-44e0-8f0e-8664ea48b745)   ![image](https://github.com/user-attachments/assets/728ec5db-9edf-4343-ba58-b3fd1f7cb152)

### Use Case Diagrams 
![image](https://github.com/user-attachments/assets/6f9d5d90-d1d3-4d29-bb3a-0d764d1de1af)

![image](https://github.com/user-attachments/assets/882f8496-b78b-426b-87e3-4ca380d79ef1)



# Part 2: 
In this section, we will analyse the requirements even further by identifying the entity classes, 
drawing class diagrams, state machine diagrams, architecture diagrams, adding collection classes, methods, and method specifications.
## User Story Entity Class Diagrams: 

## Bob's Section

**1.	As a student I want to be notified about upcoming classes and or exams/CA’s daily, so I don’t miss a deadline or exam.**
![image](https://github.com/user-attachments/assets/6fd631c1-47ce-47bf-b021-63255a0963d5)

**2.	As a student, I want to track my study time, so I can reduce stress and see how much time I am allocating to each course on a weekly basis.**

![image](https://github.com/user-attachments/assets/6c506910-5f70-47dd-a42a-755109753335)

**Entity classes for both user stories:**

![image](https://github.com/user-attachments/assets/9b637f74-ede5-452b-8041-945fdc06c559)

### Entity class relationships with cardinality for the above classes: 
1.	**Student** and **Schedule**
 - Cardinality: 1:1 (One-to-One)
 - Each student has one schedule which contains their courses, exams and events.

### Collection Classes 

**Class: Student** 
 - Collection:  List<StudySession>
 - Reason for this collection: To track multiple study sessions for the student 
**Class: Schedule** 
  - Collection:  List<Course>, List<Exam>, List<Notification>
  - Reason for this collection: To track multiple courses and exams in a schedule
**Class: Calendar** 
  - Collection:  List<StudyBlock>
  - Reason for this collection: To store study blocks or time slot events 


### Manager Classes 
Two other classes that could be needed for managing notifications and scheduling would be a NotificationManager class and a ScheduleManager class. For example,

1.	**NotificationManager** Class that manages notifications sent to students for upcoming events, like classes, exams, or study blocks.
This class would be responsible for sending notifications and reminders to the student about their classes, exams or upcoming study blocks. 

2.	**ScheduleManager** Class that handles all operations related to a student's schedule. 
This class would be responsible for managing courses, exams, and schedules for a student, such as Bob. 


### A deeper dive into each class and its methods

### Key Methods and Classes needed:

**NotificationManager class:** 
  - SendNotifications(Student studentId, Student name, String message): void 
  - ScheduleNotifications(Student studentId, DateTime datetime, String message): void 
  - GenerateDailyReminders(Student studentId): List<String>


**ScheduleManager class:**
  - GetUpcomingClasses(Student studentId, Date date): List<Course>
  - GetUpcomingExams(Student studentId, Date date): List<Exam> 

**StudySession Class**
  - StartTimer()
  - StopTimer()
  - PauseTimer()

 
### Timer Class State Machine Diagram 
![image](https://github.com/user-attachments/assets/b4a0be58-dde9-4ee5-95c7-28dfeb547f87)



## Now let's dive deeper into Christina's section   




## And now onto Adam's section 



## Briniging all the sections together

## Activity Diagram to tie all the parts togeher (shows how the features will fit together) 
![image](https://github.com/user-attachments/assets/7026bde7-1d02-4a2a-8f1f-a8b12a728061)

## Prototype (some sample classes built in C#)

**Code for Student Class:**

![StudentClassCode](https://github.com/user-attachments/assets/d4649a20-932a-4d5b-8d77-acaf53ff334c)

**Schedule Class**

![scheduleClass](https://github.com/user-attachments/assets/4da464e2-1d2e-4720-8598-17675d9a0b4d)

## Application Architecture Diagram (to see the whole picture)
![image](https://github.com/user-attachments/assets/6d8146ec-624b-4506-8952-3af34eb52a98)









