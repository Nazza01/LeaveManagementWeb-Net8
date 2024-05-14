﻿using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Controllers
{
	[Authorize(Roles = Roles.Administrator)]
	public class LeaveTypesController : Controller
	{
		private readonly ILeaveTypeRepository leaveTypeRepository;
		private readonly IMapper mapper;
		private readonly ILeaveAllocationRepository leaveAllocationRepository;

		public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
		{
			this.mapper = mapper;
			this.leaveAllocationRepository = leaveAllocationRepository;
			this.leaveTypeRepository = leaveTypeRepository;
		}

		// GET: LeaveTypes
		public async Task<IActionResult> Index()
		{
			var leaveTypes = mapper.Map<List<LeaveTypeVM>>(await leaveTypeRepository.GetAllAsync());
			return View(leaveTypes);
		}

		// GET: LeaveTypes/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			var leaveType = await leaveTypeRepository.GetAsync(id);

			if (leaveType == null)
			{
				return NotFound();
			}

			var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);

			return View(leaveTypeVM);
		}

		// GET: LeaveTypes/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: LeaveTypes/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
		{
			if (ModelState.IsValid)
			{
				var leaveType = mapper.Map<LeaveType>(leaveTypeVM);

				await leaveTypeRepository.AddAsync(leaveType);

				return RedirectToAction(nameof(Index));
			}
			return View(leaveTypeVM);
		}

		[Authorize(Roles = "Administrator")]
		// GET: LeaveTypes/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			var leaveType = await leaveTypeRepository.GetAsync(id);

			if (leaveType == null)
			{
				return NotFound();
			}

			var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);

			return View(leaveTypeVM);
		}

		// POST: LeaveTypes/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
		{
			if (id != leaveTypeVM.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
					await leaveTypeRepository.UpdateAsync(leaveType);
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!await leaveTypeRepository.ExistsAsync(leaveTypeVM.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(leaveTypeVM);
		}

		// POST: LeaveTypes/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			await leaveTypeRepository.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}

		// POST: LeaveTypes/AllocateLeave
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AllocateLeave(int id)
		{
			await leaveAllocationRepository.LeaveAllocation(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
