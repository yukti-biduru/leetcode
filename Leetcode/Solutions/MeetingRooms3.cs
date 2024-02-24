using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class MeetingRooms3
    {

        public int MostBooked(int n, int[][] meetings)
        {
            // sort the meetings based on the start times  
            Array.Sort(meetings, (a, b) => a[0] = b[0]);
            int start = 0, end = 0;
            // number of meetings in the room 
            int[] meetingRooms = new int[n];

            // next Available time in the room
            int[] nextAvailabilityTime = new int[n];

            // min available time over all rooms
            long minAvailableTime, nextAvailableRoom = 0;

            // found room?
            bool roomFound = false;

            for (int i = 0; i < meetings.Length; i++)
            {
                start = meetings[i][0];
                end = meetings[i][1];
                minAvailableTime = long.MaxValue;
                nextAvailableRoom = 0;
                roomFound = false; 
                for (int j = 0; j < n; j++)
                {
                    if (nextAvailabilityTime[j] <= start)
                    {
                        meetingRooms[j]++;
                        roomFound = true;
                        nextAvailabilityTime[j] = end;
                        break;
                    }
                    if (minAvailableTime > nextAvailabilityTime[j])
                    {
                        minAvailableTime = nextAvailabilityTime[j];
                        nextAvailableRoom = j;
                    }
                    if (!roomFound)
                    {
                        nextAvailabilityTime[nextAvailableRoom] += end - start;
                        meetingRooms[nextAvailableRoom]++;

                    }
                }
            }
            // from the nextavailabletime array find the room with the max number of meetings
            int max = int.MaxValue, maxRoom = 0;
            for (int i = 0; i < n; i++)
            {
                if(max < meetingRooms[i])
                {
                    max = meetingRooms[i];
                    maxRoom = i;
                }
            }
            return maxRoom;
        }
        public int MostBooked1(int n, int[][] meetings)
        {
            long[] roomAvailabilityTime = new long[n];
            int[] meetingCount = new int[n];
            Array.Sort(meetings, (a, b) => a[0] - b[0]);
            for (int i = 0; i < meetings.Length; i++)
            {
                int start = meetings[i][0], end = meetings[i][1];
                long minRoomAvailabilityTime = long.MaxValue;
                int minAvailableTimeRoom = 0;
                bool foundUnusedRoom = false;

                for (int j = 0; j < n; j++)
                {
                    if (roomAvailabilityTime[j] <= start)
                    {
                        foundUnusedRoom = true;
                        meetingCount[j]++;
                        roomAvailabilityTime[j] = end;
                        break;
                    }
                    if (minRoomAvailabilityTime > roomAvailabilityTime[j])
                    {
                        minRoomAvailabilityTime = roomAvailabilityTime[j];
                        minAvailableTimeRoom = j;
                    }
                    if (!foundUnusedRoom)
                    {
                        roomAvailabilityTime[minAvailableTimeRoom] += end - start;
                        meetingCount[minAvailableTimeRoom]++;
                    }
                }
            }
            int maxMeetingCount = 0, maxmeetingCountRoom = 0;
            for (int i = 0; i < n; i++)
            {
                if (meetingCount[i] > maxMeetingCount)
                {
                    maxMeetingCount = meetingCount[i];
                    maxmeetingCountRoom = i;
                }
            }
            return maxmeetingCountRoom;
        }
    }
}
