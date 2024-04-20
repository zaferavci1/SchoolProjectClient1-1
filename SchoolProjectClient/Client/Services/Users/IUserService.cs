﻿using SchoolProjectClient.Client.Model.Common;
using SchoolProjectClient.Client.Model.User;

namespace SchoolProjectClient.Client.Services.Users
{
    public interface IUserService
    {
        Task<BaseResponse<UserResponse>> GetAllUserListAsync(int page, int size);
        Task<BaseResponse<GetByIdUser>> GetUserByIdAsync(string id);
        Task<BaseResponse<User>> AddUserAsync(AddUser addUser);
        Task<BaseResponse<User>> UpdateUserAsync(UpdateUser updateUser);
        Task<BaseResponse<User>> DeleteUserAsync(string id);
    }
}

