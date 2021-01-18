using Data.Enums;
using Notenverwaltung.Core.Enums;

namespace Notenverwaltung.Core
{
    public class UserPermissions : IUserPermissions
    {
        private ModuleType _module;
        private RoleType _role;

        #region InterfaceMethods

        public bool GetDeletePermission(ModuleType module)
        {
            _module = module;

            switch (_module)
            {
                case ModuleType.SubjectManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return false;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return false;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.StudentManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.ClassManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.TeacherManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return false;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.GradeManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return true;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return false;

                        case RoleType.Admin:
                            return true;
                    }

                    break;
            }

            throw new System.NotImplementedException();
        }

        public bool GetLookPermission(ModuleType module)
        {
            _module = module;

            switch (_module)
            {
                case ModuleType.SubjectManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return false;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return false;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.StudentManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.ClassManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.TeacherManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return false;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.GradeManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return true;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return false;

                        case RoleType.Admin:
                            return true;
                    }

                    break;
            }

            throw new System.NotImplementedException();
        }

        public bool GetModifyPermission(ModuleType module)
        {
            _module = module;

            switch (_module)
            {
                case ModuleType.SubjectManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return false;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return false;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.StudentManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.ClassManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.TeacherManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return false;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.GradeManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return true;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return false;

                        case RoleType.Admin:
                            return true;
                    }

                    break;
            }

            throw new System.NotImplementedException();
        }

        public bool GetPrintPermission(ModuleType module)
        {
            _module = module;

            switch (_module)
            {
                case ModuleType.SubjectManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return false;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return false;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.StudentManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.ClassManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.TeacherManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return false;

                        case RoleType.ClassTeacher:
                            return false;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return true;

                        case RoleType.Admin:
                            return true;
                    }

                    break;

                case ModuleType.GradeManagement:
                    switch (_role)
                    {
                        case RoleType.Teacher:
                            return true;

                        case RoleType.ClassTeacher:
                            return true;

                        case RoleType.Principal:
                            return true;

                        case RoleType.AdminTeacher:
                            return false;

                        case RoleType.Admin:
                            return true;
                    }

                    break;
            }

            throw new System.NotImplementedException();
        }

        public RoleType GetRole()
        {
            return _role;
        }

        public void SetRole(RoleType roleType)
        {
            _role = roleType;
        }

        #endregion InterfaceMethods
    }
}