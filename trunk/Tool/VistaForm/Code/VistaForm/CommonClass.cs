using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
/*
 * CopyRight by cici studio 2000-2008
 * 欢迎朋友们和我联系chengchencici@163.com
 * http://www.chengchen.net
 */
namespace VistaForm
{
    /// <summary>
    /// 鼠标当前的位置
    /// </summary>
    enum VistaMousePosition
    {
        NORMAL,
        LEFTTOP,
        TOP,
        RIGHTTOP,
        LEFT,
        RIGHT,
        LEFTBOTTOM,
        RIGHTBOTTOM,
        BOTTOM
    }

    public class CommonClass
    {
        //这个API作用是获取窗口的属性
        [DllImport("user32.dll", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto)]
        static extern int GetWindowLong(HandleRef hWnd, int nIndex);

        //这个API是专门设置窗口的属性的    
        [DllImport("user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
        static extern IntPtr SetWindowLong(HandleRef hWnd, int nIndex, int dwNewLong);

        /// <summary>
        /// 系统菜单
        /// </summary>
        public const int WS_SYSMENU = 0x00080000;


        /// <summary>
        /// 设置窗体是否有最大最小按钮
        /// </summary>
        public const int WS_MINIMIZEBOX = 0x20000;

        /// <summary>
        /// 设置任务栏菜单&允许最大化最小化
        /// </summary>
        /// <param name="form">需要更改的窗体</param>
        public static void SetTaskMenu(Form form)
        {
            //获取窗体属性句柄
            int windowLong = (GetWindowLong(new HandleRef(form, form.Handle), -16));

            //设置窗体属性句柄
            SetWindowLong(new HandleRef(form, form.Handle), -16, windowLong | WS_SYSMENU | WS_MINIMIZEBOX);
            //注意，这里是重点:WS_SYSMENU允许有系统菜单 WS_MINIMIZEBOX:可以最大最小化
            //这两个参数是上面那个类里提供的
        }
    }
}
